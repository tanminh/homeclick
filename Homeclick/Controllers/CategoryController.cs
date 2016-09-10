﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System;
using VCMS.Lib.Models;
using VCMS.Lib.Models.Business;

namespace Homeclick.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryTypes CategoryType
        {
            get
            {
                return CategoryTypes.Model;
            }
        }

        public ApplicationDbContext db = new ApplicationDbContext();

        public virtual ActionResult _Sidebar()
        {
            var categories = db.Categories.Where(c => c.Category_typeId == (int)CategoryType).ToList();
            return PartialView(categories);
        }

        public ActionResult Typologies()
        {
            var typologies = db.Categories.Where(c => c.Category_typeId == (int)CategoryTypes.Typology).ToList();
            return View(typologies);
        }
    }

}