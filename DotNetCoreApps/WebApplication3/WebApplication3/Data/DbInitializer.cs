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

            #region Symbols
            var symbols = new Symbol[]
            {
                new Symbol {  Name = "EURUSD" },
                new Symbol {  Name = "AUDUSD" },
                new Symbol {  Name = "USDJPY" },
                new Symbol {  Name = "GBPUSD" },
                new Symbol {  Name = "NZDUSD" },
                new Symbol {  Name = "GBPJPY" },
                new Symbol {  Name = "USDCAD" }
            };

            foreach (var item in symbols)
            {
                context.Symbols.Add(item);
            }
            context.SaveChanges();
            #endregion

            #region Trade Types
            var tradeTypes = new TradeType[]
            {
                new TradeType {  Name = "BUY" },
                new TradeType {  Name = "SELL" }
            };

            foreach (var item in tradeTypes)
            {
                context.TradeTypes.Add(item);
            }
            context.SaveChanges();

            #endregion

            var strategies = new Strategy[]
            {
                new Strategy{ Name = "EURUSD is going UP", Description = "Is going UP - agresive strategy",
                    SymbolId = symbols.Single(i => i.Name == "EURUSD").Id,
                    TradeTypeId = tradeTypes.Single(i => i.Name == "BUY").Id,
                    Created = DateTime.Parse("2017-10-26"),
                    PriceStart = 1.167M, PriceStopLoss = 1.159M
                },
                new Strategy{ Name = "USDJPY is going DOWN", Description = "Is going to break - down",
                    SymbolId = symbols.Single(i => i.Name == "USDJPY").Id,
                    TradeTypeId = tradeTypes.Single(i => i.Name == "SELL").Id,
                    Created = DateTime.Parse("2017-10-26"),
                    PriceStart = 113.975M, PriceStopLoss = 116.001M
                },
                new Strategy{ Name = "GBPJPY is continue going UP", Description = "Is going UP",
                    SymbolId = symbols.Single(i => i.Name == "GBPJPY").Id,
                    TradeTypeId = tradeTypes.Single(i => i.Name == "BUY").Id,
                    Created = DateTime.Parse("2017-10-26"), 
                    PriceStart = 150.010M, PriceStopLoss = 146.566M
                }
            };
            foreach (var item in strategies)
            {
                context.Strategies.Add(item);
            }
            context.SaveChanges();

        }
    }
}
