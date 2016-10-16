using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Entities
{
    public class User
    {
        public int Id {get; set;}
        public string Login { get; set; } 
        public int PersId { get; set; }
        public string Password { get; set; }
    }
}
