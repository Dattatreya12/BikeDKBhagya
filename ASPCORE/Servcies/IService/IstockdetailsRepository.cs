using ASPCORE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Servcies.IService
{
    public interface IstockdetailsRepository<T>
    {
        List<T> GetAllStockDetails();
        MasterStockViewModel GetById(int id);
    }
}
