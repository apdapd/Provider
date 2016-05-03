using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Provider.Data.EntityFramework;
using Provider.Defs;
using Provider.Web.Models;

namespace Provider.Web.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 6;
        public int NOrder = 0;

        EntityWork entityWork = new EntityWork();
        public ActionResult Index(int id = 0)
        {

            
            //var listDataTarifs = entityWork.GetTarifs();

            var abonentsModel = new AbonentModel { Abonents = entityWork.GetAbonents(PageSize, id) };

            return View(abonentsModel);
        }

        public ViewResult SetOrder(int nOrder = 0)
        {
            NOrder = nOrder;
            
            return List(1);
        }

        public ViewResult List(int page = 1, int nOrder = 0)
        {
            AbonentModel model = new AbonentModel
            {
                Abonents = entityWork.GetAbonents(PageSize, (page - 1) * PageSize, nOrder),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = entityWork.AbonentsCount()
                }
            };

            return View(model);
        }

        [HttpGet]
        public ViewResult Abonent()
        {
            NewAbonentModel model = new NewAbonentModel
            {
                Tarifs = entityWork.GetTarifs()
            };

            return View(model);
        }


        [HttpPost]
        public async Task<ViewResult> Abonent(NewAbonentModel abonent)
        {
            await entityWork.AddAbonentAsync(new DataAbonent{ Address = abonent.Address, Name = abonent.Name, TarifId = abonent.TarifId});

            return Abonent();
        }



        [HttpGet]
        public ActionResult Next(int id)
        {

            /*_formView.listDataAbonent = entityWork.GetAbonents(_formView.pageSize, _formView.pageNum * _formView.pageSize, _formView.nOrder);
                ViewBag.BookId = id;*/
            return View();
        }
    }
}