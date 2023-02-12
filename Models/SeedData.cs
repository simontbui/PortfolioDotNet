using Microsoft.EntityFrameworkCore;
using PortfolioDotNet.Data;

namespace PortfolioDotNet.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PortfolioDotNetContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PortfolioDotNetContext>>()))
            {
                if (context == null || context.Comment == null)
                {
                    throw new ArgumentNullException("Null PortfolioDotNetContext");
                }

                // Look for any comments.
                if (context.Comment.Any())
                {
                    return; // DB has been seeded already
                }

                context.Comment.AddRange(
                    new Comment
                    {
                        User = "User1",
                        Text = "Hello1",
                        Date = DateTime.Parse("2023-1-30")
                    },

                    new Comment
                    {
                        User = "User2",
                        Text = "Hello2",
                        Date = DateTime.Parse("2023-1-30")
                    },

                    new Comment
                    {
                        User = "User3",
                        Text = "Hello3",
                        Date = DateTime.Parse("2023-1-30")
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}
