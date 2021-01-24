using ASPCORE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Servcies.IService
{
   public interface IprofitandLossdetailsRepository<T>
    {
        List<T> GetProfitAndLossDetails();
        InvestmentpayoutDetailsViewModel GetById(int id);
    }
}
