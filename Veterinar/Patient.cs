using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinar
{
    public class Patient
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public Patient(string name, string species)
        {
            Name = name;
            Species = species;
        }
    }

}
