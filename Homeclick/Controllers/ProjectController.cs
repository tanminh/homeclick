﻿using Homeclick.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homeclick.Controllers
{
    public class ProjectController : Controller
    {
        Homeclick.Models.vinabits_homeclickEntities db = new Models.vinabits_homeclickEntities();
        // GET: Project
        public ActionResult Index()
        {
            ViewBag.MetaKeyword = "homeclick";
            ViewBag.MetaDescription = "project";
            var types = db.Categories.Where(o => o.parent_id == 28);
            var cities = db.Cities.ToList();

            ViewBag.ProjectTypes = types;
            ViewBag.Cities = cities;

            var v = db.Projects.ToList();
            return View(v);
        }

        public ActionResult Map()
        {
            ViewBag.MetaKeyword = "homeclick";
            ViewBag.MetaDescription = "project";
            var types = db.Categories.Where(o => o.parent_id == 28);
            var cities = db.Cities.ToList();

            ViewBag.ProjectTypes = types;
            ViewBag.Cities = cities;
            return View();
        }

        public JsonResult _Collections(int? layoutId)
        {
            var list = db.ProjectLayout_Collections.Where(o => o.LockedOut == false && o.LayoutId == layoutId).ToList();
            var json = new List<object>();
            foreach (var item in list)
            {
                json.Add(new
                {
                    id = item.Id,
                    name = item.Name,
                    image = item.Image
                });
            }
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public ActionResult _CollectionDetails(int? collectionId)
        {
            if (collectionId == null)
            {

            }

            var query = string.Format("SELECT * FROM dbo.ProductsLayoutsLink WHERE Layout = '{0}'", collectionId);
            var tableItems = db.Database.SqlQuery<ProductsLayoutsLink>(query).ToList();

            var products = new List<Product>();

            foreach (var product in tableItems)
            {
                var temp_p = db.Products.Find(product.Product);
                var temp_t = temp_p.ToArray();
                var detail = temp_t["Product_detail"] as Dictionary<string, object>;
                
                products.Add(temp_p);

                product.ProductName = temp_p.name;
                product.ProductValue = Convert.ToInt32(detail["gia"]);
                product.TotalValue = product.Total * product.ProductValue;
            }

            ViewBag.Products = products;
            ViewBag.TableItems = tableItems;

            var l = db.ProjectLayout_Collections.ToList();
            var v = l.SingleOrDefault(o => o.Id == collectionId);
       
            return PartialView(v);
        }

        public ActionResult _Projects (int? typeId, string text)
        {
            var list = db.Projects.Where(o => o.LockedOut == true).ToList();

            var v = typeId != null ? db.Projects.Where(o => o.CategoryId == typeId).ToList() : db.Projects.ToList();

            if (text != null)
            {
                var b = new List<Project>();
                foreach (var item in v)
                {
                    if (item.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                        b.Add(item);
                }
                v = b;
            }
            ViewBag.SearchText = text;
            return PartialView(v);
        }

        public ActionResult Details(int? ProjectId)
        {
            var layouts = db.ProjectItems.Where(o => o.ProjectId == ProjectId && o.Category.Id == 25).ToList();
            ViewBag.Layouts = layouts;

            var firstLayoutId = layouts.FirstOrDefault().Id;
            ViewBag.firstLayoutId = firstLayoutId;


            var thumbnails = db.ProjectItems.Where(o => o.ProjectId == ProjectId && o.Category.Id == 24).ToList();
            ViewBag.Thumbnails = thumbnails;

            var project = db.Projects.ToList();
            var v = project.SingleOrDefault(o => o.Id == ProjectId);
            
            return View(v);
        }

        public JsonResult GetProjectsData()
        {
            var projects = db.Projects.ToList();
            var json = new List<object>();
            foreach (var project in projects)
            {
                json.Add(new
                {
                    id = project.Id,
                    name = project.Name,
                    image = project.Image,
                    address = project.Address,
                    city = project.CityId,
                    Investor = project.Investor,
                    viewDesignAgency = project.ViewDesignAgency,
                    architetualDesignAgency = project.ArchitetualDesignAgency,
                    furnitureDesignAgency = project.FurnitureDesignAgency,
                    constructionAgency = project.ConstructionAgency,
                    distributionAgency = project.DistributionAgency,
                    manager = project.Manager,
                    statu = Convert.ToInt32(project.Completed),
                    type = project.CategoryId,
                    link = Url.Action("details", new { ProjectId = project.Id})
                });
            }
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                             ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}