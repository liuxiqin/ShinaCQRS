using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shina.Serializing
{
    public class JsonSerializer : IJsonSerializer
    {

        public string Serialize<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public T Deserialize<T>(string jsonString)
        {
            throw new NotImplementedException();
        }
    }
}
