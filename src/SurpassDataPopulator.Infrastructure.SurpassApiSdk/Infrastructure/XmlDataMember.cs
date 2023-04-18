using System.Xml;

namespace SurpassApiSdk.Infrastructure
{
    internal class XmlDataMember
    {
        public string Name { get; set; }

        public XmlDictionaryString Namespace { get; set; }

        public bool IsCollection { get; set; }

        public bool AllowNull { get; set; }

        public List<XmlDataMember> Members { get; set; }
    }
}
