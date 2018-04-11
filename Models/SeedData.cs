using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BuffteksWebsite.Models
{
    public static class SeedData 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffteksWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                // Look for any movies.
                if (context.Client.Any())
                {
                    return;   // DB has been seeded
                }

                context.Client.AddRange(
                     new Client
                     {
                         //ClientID = 1,
                         Company = "Chop Chop",
                         CompanyContactFirstName = "John",
                         CompanyContactLastName = "Jacob",                         
                         Email = "chopchop@123.com",
                         Phone = "888-888-1789"
                     },

                      new Client
                     {
                         //ClientID = 2,
                         Company = "Baker Street",
                         CompanyContactFirstName = "Sherlock",
                         CompanyContactLastName = "Holmes",                         
                         Email = "bakerstreet@123.com",
                         Phone = "888-888-1564"
                     },


                      new Client
                     {
                        //ClientID = 3,
                         Company = "ConstructionCo",
                         CompanyContactFirstName = "Jim",
                         CompanyContactLastName = "Moriarty",                         
                         Email = "constructionco@123.com",
                         Phone = "888-888-6469"
                     }   
                );           
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }
               

                context.Project.AddRange(
                     new Project
                     {
                         //ProjectID = 1,
                         ProjectName = "Chop Chop Website",                         
                         CompanyContactLastName = "Jacob",  
                         CompanyName = "Chop Chop",
                         CompanyPhone = "888-888-1789",                     
                         CompanyEmail = "chopchop@123.com",
                         MemberLeadFirstName = "Brett",
                         MemberLeadLastName = "Ponder",
                         MemberLeadPhone = "888-888-1234",
                         MemberLeadEmail = "brett.ponder@123.com"
                     },
                     new Project
                     {
                        // ProjectID = 2,
                         ProjectName = "Baker Street Website",                         
                         CompanyContactLastName = "Holmes",  
                         CompanyName = "Baker Street",
                         CompanyPhone = "888-888-1564",                     
                         CompanyEmail = "bakerstreet@123.com",
                         MemberLeadFirstName = "Vanessa",
                         MemberLeadLastName = "Valenzuela",
                         MemberLeadPhone = "888-888-5678",
                         MemberLeadEmail = "vanessa.valenzuela@123.com"
                     },                     


                      new Project
                     {
                         //ProjectID = 2,
                         ProjectName = "ConstructionCo Website",                         
                         CompanyContactLastName = "Moriarty",  
                         CompanyName = "ConstructionCo",
                         CompanyPhone = "888-888-6469",                     
                         CompanyEmail = "constructionco@123.com",
                         MemberLeadFirstName = "Gabby",
                         MemberLeadLastName = "Ashley",
                         MemberLeadPhone = "888-888-1235",
                         MemberLeadEmail = "gabby.ashley@123.com"
                     }

                );
                 if (context.Member.Any())
                {
                    return;   // DB has been seeded
                }
                context.Member.AddRange(
                     new Member
                     {
                         //MemberID = 1,
                         FirstName = "Brett",
                         LastName = "Ponder",
                         Standing = "Senior",
                         Major = "CIS",
                         Birthday = "1/1/90",
                         Email = "brett.ponder@123.com",
                         Phone = "888-888-1234"
                     },

                     new Member
                     {
                         //MemberID = 2,
                         FirstName = "Vanessa",
                         LastName = "Valenzuela",
                         Standing = "Junior",
                         Major = "CIS",
                         Birthday = "1/1/92",
                         Email = "vanessa.valenzuela@123.com",
                         Phone = "888-888-5678"
                     },

                     new Member
                     {
                        // MemberID = 3,
                         FirstName = "Gabby",
                         LastName = "Ashley",
                         Standing = "Senior",
                         Major = "CIS",
                         Birthday = "1/1/93",
                         Email = "gabby.ashley@123.com",
                         Phone = "888-888-1235"
                     }
                  
                );


                context.SaveChanges();
            }
        }
    }
}