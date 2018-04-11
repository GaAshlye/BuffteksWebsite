using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BuffteksWebsite.Models
{
    public static class SeedMember
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffteksWebsiteContext(
                serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {
                // Look for any movies.
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