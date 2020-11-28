using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonFiles.Models
{
    public class Person
    {
        public FormFile image { get; set; }
        public Uri vkLink { get; set; }
        public Uri fbLink { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime Dob { get; set; }
        public String Address { get; set; }
        public long INN { get; set; }
        public long Kpp { get; set; }
        public long Ogrn { get; set; }
        public String City { get; set; }

        public int Ip { get; set; }
        public int lawEntities { get; set; }
        public string[] HashTags { get; set; }
        public String PhoneNumber { get; set; }
        public String CompanyLaw { get; set; }
        public String Status { get; set; }
        public bool PaidTax { get; set; } 
        public Decimal Income { get; set; }
        public Decimal Expense { get; set; }
        public String CompanyIndividual { get; set; }
        public String Participant { get; set; }
        public String Number { get; set; }
        public DateTime RequestDate { get; set; }
        public String CreditType { get; set; }
        public Decimal CreditSize { get; set; }
        public int CreditDuration { get; set; }
        public bool FZZPIndividual { get; set; }
        public bool Bankrupt { get; set; }
        public bool ExtremistList { get; set; }
    }
}
