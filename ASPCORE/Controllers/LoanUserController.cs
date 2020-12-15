using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using ASPCORE.AppDBContext;
using ASPCORE.Models;
using ASPCORE.Models.ViewModels;
using ASPCORE.Servcies;
using ASPCORE.Servcies.IService;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Document = iTextSharp.text.Document;

namespace ASPCORE.Controllers
{
    [Authorize(Roles = "Admin,Exicutive")]
    public class LoanUserController : Controller
    {
        private readonly VroomDbContext _db;
        private readonly HostingEnvironment _hostingenvironment;
        private readonly ILaonServiceemployee<LoanuserViewModels> _loanServiceemployee;
        [BindProperty]
        public LoanuserViewModels Luvm { get; set; }
        public LoanUserController(VroomDbContext db, HostingEnvironment hostingenvironment, ILaonServiceemployee<LoanuserViewModels> loanServiceemployee)
        {
            _db = db;
            _hostingenvironment = hostingenvironment;
            _loanServiceemployee = loanServiceemployee;
            Luvm = new LoanuserViewModels()
            {
                lu = new Models.Loanusers()
            };
        }
        public IActionResult LoanIndex()
        {
            var loanusers = _loanServiceemployee.GetAll();
            return View(loanusers);
        }

        [HttpGet]
        public  IActionResult Insert()
        {
            
          return View(Luvm);
        }

        //public JsonResult GetbyID(int ID)
        //{
        //    //var Employee = _db.ListAll().Find(x => x.EmployeeID.Equals(ID));
        //    var Employee = _loanServiceemployee.GetById(ID);
        //    //var Employee= _db.makes.Find(ID);
        //    string jsonresult = JsonConvert.SerializeObject(Employee);
        //    dynamic DynamicData = JsonConvert.DeserializeObject(jsonresult);
        //    return Json(DynamicData);
        //}

        public  PartialViewResult GetbyID(int ID)
        {
            //var Employee = _db.ListAll().Find(x => x.EmployeeID.Equals(ID));
            var Employee = _loanServiceemployee.GetById(ID);
            return PartialView("_lndividual_loan_details", Employee);
            //var Employee= _db.makes.Find(ID);

        }

        [HttpPost]
        public async Task <IActionResult> Insert( LoanuserViewModels item)
        {
            if(ModelState.IsValid)
            {
                if(item.CoverImage!=null)
                {
                    string folder = "Loan/loanperimg/";
                    folder += Guid.NewGuid().ToString() + "_" + item.CoverImage.FileName;
                    item.ImagePath = "/"+folder;
                    string serverFolder = Path.Combine(_hostingenvironment.WebRootPath, folder);
                    await item.CoverImage.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                }
            }
            int id = _loanServiceemployee.Insert(item);
            if(id > 0)
            {
                return View(Luvm);
            }
            else
            {

            }
           
            return View(Luvm);
        }

    }
}