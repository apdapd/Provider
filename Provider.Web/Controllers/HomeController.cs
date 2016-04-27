using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Provider.Data.EntityFramework;
using Provider.Web.Models;

namespace Provider.Web.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 6;
        EntityWork entityWork = new EntityWork();
        public ActionResult Index(int id = 0)
        {

            
            //var listDataTarifs = entityWork.GetTarifs();

            var abonentsModel = new AbonentModel { Abonents = entityWork.GetAbonents(PageSize, id) };

            return View(abonentsModel);
        }

        public ViewResult List(int page = 1)
        {
            AbonentModel model = new AbonentModel
            {
                Abonents = entityWork.GetAbonents(PageSize, (page - 1)*PageSize),
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
        public ActionResult Next(int id)
        {

            /*_formView.listDataAbonent = entityWork.GetAbonents(_formView.pageSize, _formView.pageNum * _formView.pageSize, _formView.nOrder);
                ViewBag.BookId = id;*/
            return View();
        }
    }
}