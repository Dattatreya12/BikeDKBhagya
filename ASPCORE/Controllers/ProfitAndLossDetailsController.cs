using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCORE.AppDBContext;
using ASPCORE.Models;
using ASPCORE.Models.ViewModels;
using ASPCORE.Servcies.IService;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORE.Controllers
{
    public class ProfitAndLossDetailsController : Controller
    {
        private readonly VroomDbContext _db;
        private readonly HostingEnvironment _hostingenvironment;
        private readonly IprofitandLossdetailsRepository<InvestmentpayoutDetailsViewModel> _iprofitloss;
        [BindProperty]
        public LoanuserViewModels Luvm { get; set; }
        public ProfitAndLossDetailsController(VroomDbContext db, HostingEnvironment hostingenvironment, IprofitandLossdetailsRepository<InvestmentpayoutDetailsViewModel> iprofitloss)
        {
            _db = db;
            _hostingenvironment = hostingenvironment;
            _iprofitloss = iprofitloss;
        }
        public IActionResult Index()
        {
            var stockdetails = _iprofitloss.GetProfitAndLossDetails();
            return View(stockdetails);
        }
       
        public PartialViewResult  GetbyID(int ID)
        {

            //var profitlossdetails = _db.payoutDescriptionDetails.Where(i => i.payoutID == ID /*&& i.Nmae == "abc"*/).firstordefault();

            //return PartialView("_ProfitLossDetails", profitlossdetails);
            //var Employee= _db.makes.Find(ID);
            var individualstock = _iprofitloss.GetById(ID);
            return PartialView("_ProfitAndLoassDescription", individualstock);
            

        }
    }
}