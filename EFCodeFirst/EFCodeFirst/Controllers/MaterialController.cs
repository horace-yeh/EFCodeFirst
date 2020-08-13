using EFCodeFirst.Models;
using EFCodeFirst.Models.ViewModels;
using EFCodeFirst.Repository;
using EFCodeFirst.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class MaterialController : Controller
    {
        private IRepository<Material> materialRepository;

        public MaterialController()
        {
            this.materialRepository = new GenericRepository<Material>();
        }


        // GET: Material
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 取得所有物料資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult JsonGetListData()
        {
            try
            {
                var temp = this.materialRepository.GetAll().ToList();
                var model = new MaterialViewModel() { ListData = temp };
                return Json(new ReData { Success = true, Data = model }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new ReData { Success = false, Message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// 新增物料
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult JsonCreate(Material material)
        {
            try
            {
                material.Creater = 1;
                material.LastEditor = 1;
                material.CreatDate = DateTime.Now;
                material.LastUpdate = material.CreatDate;
                this.materialRepository.Create(material);
                return Json(new ReData { Success = true });
            }
            catch (Exception ex)
            {
                return Json(new ReData { Success = false, Message = ex.Message });
            }
        }

        /// <summary>
        /// 物料變更
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult JsonUpdate(Material material)
        {
            try
            {
                var item = this.materialRepository.Get( x=> x.ID == material.ID);
                item.Name = material.Name;
                item.No = material.No;
                item.LastEditor = 1;
                item.LastUpdate = DateTime.Now;
                this.materialRepository.Update(item);
                return Json(new ReData { Success = true });
            }
            catch (Exception ex)
            {
                return Json(new ReData { Success = false, Message = ex.Message });
            }
        }

        /// <summary>
        /// 物料刪除
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult JsonDelete(Material material)
        {
            try
            {
                this.materialRepository.Delete(material);
                return Json(new ReData { Success = true });
            }
            catch (Exception ex)
            {
                return Json(new ReData { Success = false, Message = ex.Message });
            }
        }
    }
}