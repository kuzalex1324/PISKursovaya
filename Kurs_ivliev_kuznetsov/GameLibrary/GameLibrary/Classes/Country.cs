using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibraryDA.Classes
{
    public class Country
    {
        public string Name { get; set; }
        public string ISO_Code { get; set; }
        public Country(string name)
        {
            Name = name;
            ISO_Code = "";
        }

        public Country(string name, string ISO_code)
        {
            Name = name;
            ISO_Code = ISO_code;
        }

    }
}
