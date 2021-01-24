using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCORE.AppDBContext;
using ASPCORE.Models.ViewModels;
using ASPCORE.Servcies.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORE.Controllers
{
    [Authorize(Roles = "Admin,Exicutive")]
    public class StockDetailsController : Controller
    {
        private readonly VroomDbContext _db;
        private readonly HostingEnvironment _hostingenvironment;
        private readonly IstockdetailsRepository<MasterStockViewModel> _stockdetails;
        public StockDetailsController(VroomDbContext db, HostingEnvironment hostingenvironment, IstockdetailsRepository<MasterStockViewModel> stockdetails)
        {
            _db = db;
            _hostingenvironment = hostingenvironment;
            _stockdetails = stockdetails;
        }

        public IActionResult Index()
        {
            var stockdetails = _stockdetails.GetAllStockDetails();
            return View(stockdetails);
        }

        public PartialViewResult GetbyID(int ID)
        {
            //var Employee = _db.ListAll().Find(x => x.EmployeeID.Equals(ID));
            var individualstock = _stockdetails.GetById(ID);
            return PartialView("_Individualstockdetails", individualstock);
            //var Employee= _db.makes.Find(ID);

        }
    }
}