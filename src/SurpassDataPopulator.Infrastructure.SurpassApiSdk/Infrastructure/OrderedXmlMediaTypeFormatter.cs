using System.Collections;
using System.Collections.Concurrent;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace SurpassApiSdk.Infrastructure;

public class OrderedXmlMediaTypeFormatter : XmlMediaTypeFormatter
{
    private readonly ConcurrentDictionary<Type, List<XmlDataMember>> _serializerCache =
        new ConcurrentDictionary<Type, List<XmlDataMember>>();

    /// <summary>
    /// Called during deserialization to read an object of the specified type from the specified readStream.
    /// </summary>
    /// <returns>
    /// A Task whose result will be the object instance that has been read.
    /// </returns>
    /// <param name="type">The type of object to read.</param>
    /// <param name="readStream">The Stream from which to read.</param>
    /// <param name="content">The HttpContent for the content being read.</param>
    /// <param name="formatterLogger">The IFormatterLogger to log events to.</param>
    public override Task<object> ReadFromStreamAsync(
        Type type,
        Stream readStream,
        HttpContent content,
        IFormatterLogger formatterLogger)
    {
        if (readStream is null)
        {
            throw new ArgumentNullException(nameof(readStream));
        }

        if (!UseXmlSerializer)
        {
            using (var reader = new StreamReader(readStream))
            {
                var stringData = reader.ReadToEnd();
                readStream.Position = 0;

                var doc = XDocument.Parse(stringData);
                if (doc.Root != null)
                {
                    var members = GetMembersByType(type);
                    var parent = doc.Root;
                    ReorderNodes(parent, members);
                }

                readStream.Close();

                readStream = new MemoryStream();
                doc.Save(readStream);
                readStream.Position = 0;
            }
        }

        return base.ReadFromStreamAsync(type, readStream, content, formatterLogger);
    }

    private static PropertyInfo GetPrivateProperty(string name, object obj)
    {
        return obj?.GetType().GetProperty(
            name,
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.GetProperty);
    }

    private static PropertyInfo GetPublicProperty(string name, object obj)
    {
        return obj?.GetType().GetProperty(
            name,
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.GetProperty);
    }

    private List<XmlDataMember> GetMembersByType(Type type)
    {
        List<XmlDataMember> members;

        throw new NotImplementedException();

        return members;
    }

    private void ReorderNodes(XElement parent, List<XmlDataMember> members, XNamespace customNamespace = null)
    {
        if (members != null && members.Any() && parent.HasElements)
        {
            if (members.Count == 1 && members[0].IsCollection)
            {
                var itemMembers = members[0].Members;
                if (itemMembers != null && itemMembers.Any())
                {
                    foreach (var item in parent.Elements())
                    {
                        if (customNamespace != null)
                            item.Name = customNamespace + item.Name.LocalName;

                        ReorderNode(item, itemMembers, customNamespace);
                    }
                }
            }
            else
            {
                ReorderNode(parent, members, customNamespace);
            }
        }
    }

    private void ReorderNode(XElement parent, List<XmlDataMember> members, XNamespace customNamespace)
    {
        var elements = parent.Elements().ToList();
        var ordered = members.Select(
            m =>
            {
                var node = elements.FirstOrDefault(e => e.Name.LocalName == m.Name);
                if (node != null)
                {
                    var customXmlns = node.Attributes().FirstOrDefault(
                        x => x.Name.NamespaceName == "http://www.w3.org/2000/xmlns/" &&
                             !string.IsNullOrEmpty(x.Name.LocalName) && x.IsNamespaceDeclaration);
                    XNamespace customNs = null;
                    if (customXmlns != null
                        && !string.IsNullOrEmpty(m.Namespace?.Value))
                    {
                        customXmlns.Value = m.Namespace?.Value;
                        customNs = node.GetNamespaceOfPrefix(customXmlns.Name.LocalName);
                    }
                    else if (customNamespace != null)
                    {
                        node.Name = customNamespace + node.Name.LocalName;
                    }

                    ReorderNodes(node, m.Members, customNs ?? customNamespace);
                    elements.Remove(node);

                    return node;
                }

                if (!m.AllowNull)
                    return null;

                var nilAttr = new XAttribute(XName.Get("nil", "http://www.w3.org/2001/XMLSchema-instance"), "true");

                if (m.Namespace != null)
                    return new XElement(XName.Get(m.Name, m.Namespace.Value), nilAttr);

                return new XElement(m.Name, nilAttr);
            }).Where(x => x != null).ToList();
        parent.RemoveNodes();
        ordered.AddRange(elements);
        parent.Add(ordered);
    }

    private T GetPrivatePropertyValue<T>(string name, object obj)
    {
        return (T)GetPrivateProperty(name, obj)?.GetValue(obj);
    }

    private T GetPublicPropertyValue<T>(string name, object obj)
    {
        return (T)GetPublicProperty(name, obj)?.GetValue(obj);
    }

    private List<XmlDataMember> GetContractMembers(object dataContract)
    {
        if (dataContract == null)
            return null;

        var isValueType = GetPrivatePropertyValue<bool>("IsValueType", dataContract);
        if (isValueType)
            return null;

        if (dataContract.GetType().Name == "CollectionDataContract")
        {
            return new List<XmlDataMember>
            {
                new XmlDataMember
                {
                    Name = "Item",
                    IsCollection = true,
                    Members = GetContractMembers(
                        GetPublicPropertyValue<object>("ItemContract", dataContract)),
                    AllowNull = true
                }
            };
        }

        var membersProperty = GetPrivateProperty("Members", dataContract);
        if (membersProperty == null)
            return null;

        var members = new List<XmlDataMember>();

        var baseContractProprety = GetPrivateProperty("BaseContract", dataContract);

        if (baseContractProprety != null)
        {
            var baseMembers = GetContractMembers(baseContractProprety.GetValue(dataContract));
            if (baseMembers != null)
            {
                members.AddRange(baseMembers);
            }
        }

        var dataMembers = ((IEnumerable)membersProperty.GetValue(dataContract)).Cast<object>()
            .Select(
                x =>
                {
                    var memberTypeContract = GetPrivatePropertyValue<object>("MemberTypeContract", x);
                    var nm =
                        GetPublicProperty("Namespace", memberTypeContract).GetValue(memberTypeContract) as
                            XmlDictionaryString;
                    if (nm != null && (string.IsNullOrEmpty(nm.Value) ||
                                       nm.Value == "http://www.w3.org/2001/XMLSchema"))
                    {
                        nm = null;
                    }

                    var allowNull = !GetPrivatePropertyValue<bool>("IsValueType", memberTypeContract) ||
                                    GetPrivatePropertyValue<bool>("IsNullable", x);

                    return new XmlDataMember
                    {
                        Name = GetPrivatePropertyValue<string>("Name", x),
                        Namespace = nm,
                        Members = GetContractMembers(memberTypeContract),
                        AllowNull = allowNull
                    };
                });

        members.AddRange(dataMembers);
        return members;
    }
}