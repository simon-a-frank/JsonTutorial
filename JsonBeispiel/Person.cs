using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace JsonBeispiel
{
    [DataContract]
    class Person
    {
        [DataMember]
        public string Vorname { get; set; }

        [DataMember(Name = "Nachname")]
        public string Familienname { get; set; }

        [DataMember]
        public int Alter { get; set; }
    }
}
