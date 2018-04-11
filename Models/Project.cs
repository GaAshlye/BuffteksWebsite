using System;

namespace BuffteksWebsite.Models
{
    public class Project
    {
        public int ProjectID{ get; set; }
        public string ProjectName{get; set;}                
        public string CompanyContactLastName{ get; set; }
        public string CompanyName{get; set;}
        public string CompanyPhone{get; set;}
        public string CompanyEmail{get; set;}
        public string MemberLeadFirstName{get; set;}
        public string MemberLeadLastName{get; set;}
        public string MemberLeadPhone{get; set;}
        public string MemberLeadEmail{get; set;}
    
    }
}