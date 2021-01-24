using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Models
{
    public class PayOutDetails
    {
        public int ID { get; set; }
        public string StockName { get; set; }
        public int DayProfit { get; set; }
        public int DayLoss { get; set; }
        public int Totalprofit { get; set; }
        public int Totalloss { get; set; }
        public int DayPayout { get; set; }
        public int TotalPayOut { get; set; }
        public DateTime ExecutedDate { get; set; }
        public int Bid { get; set; }

    }
}
