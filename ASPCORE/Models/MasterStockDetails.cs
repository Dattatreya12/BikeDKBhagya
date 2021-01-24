using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Models
{
    public class MasterStockDetails
    {
        public int Id { get; set; }
        //Shibv/Dattu
        public string StockHolderName { get; set; }
        //Tata
        public string StockName { get; set; }
        //Buy/Sell
        public string Mode { get; set; }
        //Intraday/Delivery
        public string StockType { get; set; }
        //Total Qty
        public int TotalQuantity { get; set; }
        //Buy Rate
        public int BuyRate { get; set; }
        //Sell Rate
        public int SellRate { get; set; }
        //investment
        public int Investment { get; set; }
        //Total investment
        public int TotalInvestment { get; set; }
        //Profit
        public int Profit { get; set; }
        //Loss
        public int Loss { get; set; }
        //Total Gain /Loss
        public int TotalGainLoss { get; set; }
        //Start Date
        public DateTime StartDate { get; set; }
        //End Date
        public DateTime EndDate { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int SID { get; set; }
        public StockInvestorDetails stockInvestorDetails { get; set; }
    }
}
