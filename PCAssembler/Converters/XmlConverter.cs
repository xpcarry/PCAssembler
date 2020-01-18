using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PCAssembler.Converters
{
    public class XmlConverter
    {
        private readonly List<Component> _components;
        public XmlConverter(List<Component> components)
        {
            _components = components;
        }

        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("PCAssembler");
            var xAttributes = _components
                .Select(c => new XElement("Component",
                                    new XAttribute("Name", c.Name),
                                    new XAttribute("Type", c.Type),
                                    new XAttribute("Efficency", c.Efficency),
                                    new XAttribute("Price", c.Price)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
