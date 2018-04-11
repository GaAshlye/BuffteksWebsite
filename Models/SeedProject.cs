using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BuffteksWebsite.Models
{
    public static class SeedProject
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffteksWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                // Look for any movies.
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
                context.SaveChanges();
            }
        }
    }
}