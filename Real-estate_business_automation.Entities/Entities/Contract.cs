using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_business_automation.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int CustId { get; set; }
        public int EstateId { get; set; }
        public DateTime Date { get; set; }

    }
}
