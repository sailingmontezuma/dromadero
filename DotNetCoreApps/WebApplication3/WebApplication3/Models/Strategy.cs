using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Strategy
    {
        public Strategy()
        {
            //Trades = new List<Trade>();
            //Comments = new List<Comment>();
            //Created = DateTime.Now;
        }
        public int Id { get; set; }

        public DateTime Created { get; set; }

        //public DateTime Modified { get; set; }

        //public bool IsActive { get; set; }

        [Display(Name = "Strategy name")]
        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Price entry")]
        public decimal PriceStart { get; set; }

        [Display(Name = "Price stop loss")]
        public decimal PriceStopLoss { get; set; }

        //[Display(Name = "Price entry tolerance")]
        //[DataType(DataType.Currency)]
        //public decimal PriceStartTolerance { get; set; }

        //[Display(Name = "Price exit tolerance")]
        //public decimal PriceEnd { get; set; }

        //[Display(Name = "Price tolerance - end")]
        //public int PriceEndTolerance { get; set; }

        //[Display(Name = "Started")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DateStart { get; set; }

        //[Display(Name = "Ended")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DateEnd { get; set; }

        public Symbol Symbol { get; set; }

        public int SymbolId { get; set; }

        public TradeType TradeType { get; set; }

        public int TradeTypeId { get; set; }

        /// <summary>
        /// Strategy relelated to.
        /// As a follow up
        /// </summary>
        //public int ParentStrategyId { get; set; }
        //public virtual Strategy ParentStrategy { get; set; }
        //public List<Trade> Trades { get; set; }
        //public List<Comment> Comments { get; set; }
    }
}
