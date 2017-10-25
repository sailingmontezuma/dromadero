using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class DbInitializer
    {
        public static void Initialize(FxContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Strategies.Any())
            {
                return; // DB has been seeded
            }
            var strategies = new Strategy[]
            {
                new Strategy{ Name = "EURUSD is going UP", Description = "Is going UP", Symbol = SymbolEnum.Eurusd,
                 TradeType = TradeTypeEnum.Buy, Created =DateTime.Parse("2017-10-22")},
       
            };
            foreach (var item in strategies)
            {
                context.Strategies.Add(item);
            }
            context.SaveChanges();

        }
    }
    }
