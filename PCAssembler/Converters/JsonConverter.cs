using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler.Converters
{
    public class JsonConverter
    {
        private IEnumerable<Component> _components;

        public JsonConverter(IEnumerable<Component> components)
        {
            _components = components;
        }

        public string ConvertToJson()
        {
            var jsonComponents = JsonConvert.SerializeObject(_components, Formatting.Indented);
            Console.WriteLine(jsonComponents);
            return jsonComponents;
        }
    }
}
