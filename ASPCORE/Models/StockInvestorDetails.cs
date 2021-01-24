using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Models
{
    public class StockInvestorDetails
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int TotalCapital { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ICollection<MasterStockDetails> masterStockDetails { get; set; }
    }
}
