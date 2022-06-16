using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment.Domain.Modals
{
    public class Investor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvestorID { get; set; }
        [MaxLength(100)]
        public string InvestorName { get; set; }
        [MaxLength(20)]
        public string ContactNo { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        public int ShareValue { get; set; }
        public int SharePrice { get; set; }
        public int ShareQTY { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string IDType { get; set; }
    }
}
