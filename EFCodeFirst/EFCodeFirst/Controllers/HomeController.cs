using EFCodeFirst.Models;
using EFCodeFirst.Repository;
using EFCodeFirst.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Material> materialRepository;

        public HomeController()
        {
            this.materialRepository = new GenericRepository<Material>();
        }


        public ActionResult Index()
        {
            //var test = "";
            //insert
            //var item = new Material() { Name ="水果", No="P0001",Creater = 1,LastEditor = 1,CreatDate = DateTime.Now, LastUpdate = DateTime.Now};
            //this.materialRepository.Create(item);

            //Get by id
            //var item = this.materialRepository.Get(x => x.ID == 3);

            //GetAll

            //var item = this.materialRepository.GetAll().ToList();

            //update
            //var item = this.materialRepository.Get(x => x.ID == 3);
            //item.No = "P0002";
            //this.materialRepository.Update(item);

            //delete 
            //var item = new Material() { Name = "水果2", No = "P0001", Creater = 1, LastEditor = 1, CreatDate = DateTime.Now, LastUpdate = DateTime.Now };
            //this.materialRepository.Create(item);
            //var item2 = this.materialRepository.Get(x => x.No == "P0001");
            //this.materialRepository.Delete(item2);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}