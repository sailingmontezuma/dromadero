using System.Collections.Generic;

namespace Patl.Domain
{
    public class History
    {
        public History()
        {
            Transactions = new List<Transaction>();
        }

        public List<Transaction> Transactions { get; set; }
    }
}
