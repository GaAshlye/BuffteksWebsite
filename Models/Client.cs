using System;

namespace BuffteksWebsite.Models
{
    public class Client
    {
        public int ClientID{ get; set; }
        public string Company{get; set;}
        public string CompanyContactFirstName{ get; set; }
        public string CompanyContactLastName{ get; set; }     
        public string Email{ get; set; }
        public string Phone{ get; set; }
    }
}