using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Dynamic;

namespace TopazParametrizer.Persistence
{
    public static class jsonParser
    {   
        public static ExpandoObject convertText(string jsonText)
        {
            ExpandoObject data = new ExpandoObject();
            if (jsonText != null)
            {
                data = JsonConvert.DeserializeObject<ExpandoObject>(jsonText);
            }
            return data;
        }
    }
}
