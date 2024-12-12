using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Genericos
{
    public class LeerJson
    {
        public List<POCO.PrincipalData> principal_data() 
        {
            var json = JsonConvert.DeserializeObject<Dictionary<String, List<POCO.PrincipalData>>>(File.ReadAllText(@"..\..\..\Data\principal.json"));
            return json["operaciones"]; 
        }
    }
}
