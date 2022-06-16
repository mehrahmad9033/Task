using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.DTOS
{
    public class InvestorDTO
    {
        public int InvestorID { get; set; } 
        public string InvestorName { get; set; } 
        public string ContactNo { get; set; } 
        public string Address { get; set; } 
        public string City { get; set; }
        public int ShareValue { get; set; }
        public int SharePrice { get; set; }
        public int ShareQTY { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string IDType { get; set; }
        public object CompanyID { get; internal set; }
    }
}
