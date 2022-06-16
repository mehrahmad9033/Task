using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.DTOS
{
    public class CompanyDTO
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public ResponseObj Response { get; set; }
    }
}
