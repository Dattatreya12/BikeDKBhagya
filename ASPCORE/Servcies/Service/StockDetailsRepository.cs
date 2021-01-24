using ASPCORE.AppDBContext;
using ASPCORE.Models.ViewModels;
using ASPCORE.Servcies.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Servcies.Service
{
    public class StockDetailsRepository : IstockdetailsRepository<MasterStockViewModel>
    {
        private readonly VroomDbContext _db;

        public StockDetailsRepository(VroomDbContext db)
        {
            _db = db;
        }
        public List<MasterStockViewModel> GetAllStockDetails()
        {
            var stockdetails = new List<MasterStockViewModel>();
            var stocks = (from sid in _db.StockInvestorDetails
                            join sd in _db.masterStockDetails on sid.ID equals sd.SID
                            select new
                            {
                                sid.FullName,
                                sid.TotalCapital,
                                sd.Id,
                                sd.StockName,
                                sd.TotalQuantity,
                                sd.Mode,
                                sd.StockType,
                                sd.BuyRate,
                                sd.SellRate
                            }
                                 ).ToList();

            if (stocks?.Any() == true)
            {
                foreach (var s in stocks)
                {
                    stockdetails.Add(new MasterStockViewModel()
                    {
                                Id = s.Id,
                                FullName =s.FullName,
                                TotalCapital=s.TotalCapital,
                                StockName = s.StockName,
                                TotalQuantity=s.TotalQuantity,
                                Mode=s.Mode,
                                StockType=s.StockType,
                                BuyRate=s.BuyRate,
                                SellRate=s.SellRate
                        //Id = loan1.Id,
                        //ImagePath = loan1.ImagePath,
                        //FirstName = loan1.FirstName,
                        //LastName = loan1.LastName,
                        //Phoneno = loan1.Phoneno,
                        //Loanstatus = loan1.Loanstatus,
                        //address = loan1.address
                    });
                }
            }

            return stockdetails;
        }

        public MasterStockViewModel GetById(int id)
        {
            MasterStockViewModel stockdetails = (from sid in _db.StockInvestorDetails
                                             join sd in _db.masterStockDetails on sid.ID equals sd.SID
                                             where sd.Id == id
                                             select new MasterStockViewModel
                                             {
                                                 StockName = sd.StockName,
                                                 Investment = sd.Investment,
                                                 TotalInvestment = sd.TotalInvestment,
                                                 Profit = sd.Profit,
                                                 Loss = sd.Loss,
                                                 StartDate = sd.StartDate,
                                                 EndDate = sd.EndDate,
                                                
                                             }).FirstOrDefault();

            return stockdetails;
        }
    }
}
