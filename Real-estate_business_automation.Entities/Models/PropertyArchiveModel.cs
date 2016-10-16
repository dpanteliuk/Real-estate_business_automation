using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Entities
{
    public class PropertyArchiveModel :PropertyViewModel
    {
        public Person Employee { get; set; }
        public Person Customer { get; set; }
        public DateTime Date { get; set; }

        public PropertyArchiveModel():base()
        {
            Employee = new Person();
            Customer = new Person();
        }
        

    }
}
