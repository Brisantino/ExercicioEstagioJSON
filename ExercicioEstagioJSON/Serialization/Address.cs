using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstagioJSON.Serialization
{
    public class Address
    {
        public string street { get; set; }
        public string suit { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public Geo geo { get; set; }
    }
}
