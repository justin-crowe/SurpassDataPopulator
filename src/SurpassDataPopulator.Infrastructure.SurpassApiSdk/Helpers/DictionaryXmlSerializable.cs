using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SurpassApiSdk.Helpers
{
    [Serializable]
    public class DictionaryXmlSerializable<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {
        public DictionaryXmlSerializable()
        {
        }

        public DictionaryXmlSerializable(IDictionary<TKey, TValue> dictionary)
            : base(dictionary)
        {
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            var keySerializer = new XmlSerializer(typeof(TKey), new XmlRootAttribute("Key"));
            var valueSerializer = new XmlSerializer(typeof(TValue), new XmlRootAttribute("Value"));

            var isEmpty = reader.IsEmptyElement;
            reader.Read();

            if (isEmpty)
                return;

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement("Item");

                var key = (TKey)keySerializer.Deserialize(reader);
                var value = (TValue)valueSerializer.Deserialize(reader);

                Add(key, value);

                reader.ReadEndElement();
                reader.MoveToContent();
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            var keySerializer = new XmlSerializer(typeof(TKey), new XmlRootAttribute("Key"));
            var valueSerializer = new XmlSerializer(typeof(TValue), new XmlRootAttribute("Value"));

            foreach (var item in this)
            {
                writer.WriteStartElement("Item");
                keySerializer.Serialize(writer, item.Key, ns);
                valueSerializer.Serialize(writer, item.Value, ns);
                writer.WriteEndElement();
            }
        }
    }
}
