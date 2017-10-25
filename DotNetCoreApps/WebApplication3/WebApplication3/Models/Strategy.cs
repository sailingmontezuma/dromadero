using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime Modified { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Price entry")]
        public decimal PriceStart { get; set; }

        [Display(Name = "Price entry tolerance")]
        public int PriceStartTolerance { get; set; }

        [Display(Name = "Price exit tolerance")]
        public decimal PriceEnd { get; set; }

        [Display(Name = "Price tolerance - end")]
        public int PriceEndTolerance { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateStart { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateEnd { get; set; }
        public SymbolEnum Symbol { get; set; }
        public TradeTypeEnum TradeType { get; set; }

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
