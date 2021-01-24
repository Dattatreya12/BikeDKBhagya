using ASPCORE.AppDBContext;
using ASPCORE.Models;
using ASPCORE.Models.ViewModels;
using ASPCORE.Servcies.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Servcies.Service
{
    public class ProfitandLossdetailsRepository : IprofitandLossdetailsRepository<InvestmentpayoutDetailsViewModel>
    {
        private readonly VroomDbContext _db;
      
        public ProfitandLossdetailsRepository(VroomDbContext db)
        {
            _db = db;
        }
        public List<InvestmentpayoutDetailsViewModel> GetProfitAndLossDetails()
        {
          
            var result = new List<InvestmentpayoutDetailsViewModel>();
            var stocks = (from Im in _db.investmentMasters
                          join Pd in _db.payOutDetails on Im.ID equals Pd.Bid
                          select new
                          {
                              Im.BrokerName,
                              Pd.StockName,
                              Im.Investment,
                              Im.ID,
                              Im.CreatedOn,
                              Pd.DayProfit,
                              Pd.DayLoss,
                              Pd.Totalprofit,
                              Pd.Totalloss,
                              Pd.DayPayout,
                              Pd.TotalPayOut,
                              Pd.ExecutedDate,
                              //sid.FullName,
                              //sid.TotalCapital,
                              //sd.Id,
                              //sd.StockName,
                              //sd.TotalQuantity,
                              //sd.Mode,
                              //sd.StockType,
                              //sd.BuyRate,
                              //sd.SellRate
                          }
                                 ).ToList();

            if (stocks?.Any() == true)
            {
                foreach (var s in stocks)
                {
                    result.Add(new InvestmentpayoutDetailsViewModel()
                    {
                        ID = s.ID,
                        BrokerName =s.BrokerName,
                        StockName = s.StockName,
                        Investment = s.Investment,
                        CreatedOn = s.CreatedOn,
                        DayProfit = s.DayProfit,
                        DayLoss = s.DayLoss,
                        Totalprofit = s.Totalprofit,
                        Totalloss = s.Totalloss,
                        DayPayout = s.DayPayout,
                        TotalPayOut = s.TotalPayOut,
                        ExecutedDate = s.ExecutedDate,
                    });
                }
            }

            return result;
        }

        //public PayoutDescriptionDetails GetById(int id)
        //{

        //    var stockdetails = from desc in _db.payoutDescriptionDetails
        //                                                                 select desc; 

        //    return stockdetails;
        //}
    }
}
