using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Entities
{
    public class PropertyViewModel
    {
        public Estate Estate { get; set; }
        public Person Owner { get; set; }
        public District District { get; set; }

        public PropertyViewModel()
        {
            Estate = new Estate();
            Owner = new Person();
        }

    }
}
