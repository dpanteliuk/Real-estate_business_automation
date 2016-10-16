using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Entities
{
    public class Estate
    {
        public int Id { get; set; }
        public int? DistrictId { get; set; }
        public int Rooms { get; set; }
        public double Area { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public int OwnerId { get; set; }
        public bool Rent { get; set; }
        public bool Sale { get; set; }
    }
}
