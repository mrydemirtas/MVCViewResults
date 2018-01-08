using MVCViewResults.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewResults.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// dbden kategoriler alır.
        /// </summary>
        /// <returns></returns>
        public List<CategoryVM> GetCategories()
        {
            return new List<CategoryVM>
            {
                new CategoryVM
                {
                    Name="A"
                },
                new CategoryVM
                {
                    Name="B"
                }
            };
        }

        public List<MenuVM> GetMenus()
        {
            return new List<MenuVM>
            {
                new MenuVM
                {
                    Name = "Hakkımızda",
                    Url = "/Home/About"
                },
                new MenuVM
                {
                    Name = "İletişim",
                    Url = "/Home/Contact"
                }
            };
        }

        public ActionResult Index()
        {
            IndexVM model = new IndexVM();
            model.Categories = GetCategories();
            model.Menus = GetMenus();

            model.Content = new ContentVM();
            model.Content.Title = "Anasayfa";
            model.Content.Content = "Testtt";

            return View(model);
        }



    }
}