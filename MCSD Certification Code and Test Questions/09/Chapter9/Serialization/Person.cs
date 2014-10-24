using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ConsoleApplication2
{
    [Serializable]
    public class Person : ISerializable
    {
        
        private int _id;        
        
        public string FirstName;
        
        public string LastName;

        public void SetId(int id)
        {
            _id = id;
        }

        public Person() { }

        public Person(SerializationInfo info, StreamingContext context)
        {
            FirstName = info.GetString("custom field 1");
            LastName = info.GetString("custom field 2");
        }
                
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("custom field 1", FirstName);
            info.AddValue("custom field 2", LastName);
        }
    }
}
