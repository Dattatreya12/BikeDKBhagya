using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Servcies.IService
{
   public interface IprofitandLossdetailsRepository<T>
    {
        List<T> GetProfitAndLossDetails();
        //string GetById(int id);
    }
}
