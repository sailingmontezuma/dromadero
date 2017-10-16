using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Patl.WebApp.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Trades.Any())
            {
                context.AddRange(
                    new Trade
                    {
                        Name = "Catch up trend",
                        Description = "quickly react on side up",
                        Id = 1,
                        IsTradeOfTheMonth = false,
                        PriceOpen = 1.24432M,
                        PriceClose = 1.223345M,
                        Category = Categories["Fruit pies"],
                        Symbol = "EURUSD",
                        Open = new DateTime(2017, 10, 3, 9, 34, 45, DateTimeKind.Utc),
                        Close = new DateTime(2017, 10, 3, 9, 38, 55, DateTimeKind.Utc)
                    },
                    new Trade
                    {
                        Name = "Close as soon as possible",
                        Description = "bad trade",
                        Id = 2,
                        IsTradeOfTheMonth = false,
                        PriceOpen = 1.1134M,
                        PriceClose = 1.03455M,
                        Category = Categories["Cheese cakes"],
                        Symbol = "GBPUSD",
                        Open = new DateTime(2017, 10, 3, 9, 34, 11, DateTimeKind.Utc),
                        Close = new DateTime(2017, 10, 6, 9, 38, 55, DateTimeKind.Utc)
                    }
                    
                  );
            }
            context.SaveChanges();

        }


        #region Categories

        private static Dictionary<string, Category> categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category {  Name = "Fruit pies" },
                        new Category { Name = "Cheese cakes" },
                        new Category { Name = "Seasonal pies" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.Name, genre);
                    }
                }

                return categories;
            }
        }

        #endregion



    }
}
