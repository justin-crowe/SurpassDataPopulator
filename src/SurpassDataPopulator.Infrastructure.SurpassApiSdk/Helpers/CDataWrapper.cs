using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SurpassApiSdk.Helpers
{
    [XmlSchemaProvider("GenerateSchema")]
    public sealed class CDataWrapper : IXmlSerializable
    {
        // underlying value
        public string Value { get; set; }

        // implicit to/from string
        public static implicit operator string(CDataWrapper value)
        {
            return value == null ? null : value.Value;
        }

        public static implicit operator CDataWrapper(string value)
        {
            return value == null ? null : new CDataWrapper { Value = value };
        }

        // return "xs:string" as the type in scheme generation
        public static XmlQualifiedName GenerateSchema(XmlSchemaSet xs)
        {
            return XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).QualifiedName;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        // "" => <Node/>
        // "Foo" => <Node><![CDATA[Foo]]></Node>
        public void WriteXml(XmlWriter writer)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (!string.IsNullOrEmpty(Value))
            {
                writer.WriteCData(Value);
            }
        }

        // <Node/> => ""
        // <Node></Node> => ""
        // <Node>Foo</Node> => "Foo"
        // <Node><![CDATA[Foo]]></Node> => "Foo"
        public void ReadXml(XmlReader reader)
        {
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (reader.IsEmptyElement)
            {
                Value = string.Empty;
            }
            else
            {
                reader.Read();

                switch (reader.NodeType)
                {
                    case XmlNodeType.EndElement:
                        Value = string.Empty; // empty after all...
                        break;
                    case XmlNodeType.Text:
                    case XmlNodeType.CDATA:
                        Value = reader.ReadContentAsString();
                        break;
                    default:
                        throw new InvalidOperationException("Expected text/cdata");
                }
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
