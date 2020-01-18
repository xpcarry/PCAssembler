using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler.Converters
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public string ConvertXmlToJson()
        {
            var components = _xmlConverter.GetXML()
                    .Element("PCAssembler")
                    .Elements("Component")
                    .Select(c => new CPU
                    {
                        Name = c.Attribute("Name").Value,
                        Type = c.Attribute("Type").Value,
                        Efficency = Convert.ToInt32(c.Attribute("Efficency").Value),
                        Price = Convert.ToDouble(c.Attribute("Price").Value)
                    });

            return new JsonConverter(components)
                 .ConvertToJson();
        }
    }
}
