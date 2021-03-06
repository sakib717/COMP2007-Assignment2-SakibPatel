﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_Assignment2_SakibPatel.Models;

namespace COMP2007_Assignment2_SakibPatel.Controllers
{
    public class BistroController : Controller
    {
        //
        // GET: /Bistro/
        public ActionResult Index()
        {
            List<Cuisine> cuisines = new List<Cuisine>
    {
        new Cuisine("Indian"),
        new Cuisine ("Italian"),
        new Cuisine ("Chinese")
    };
            return View(cuisines);
        }
        //
        // GET: /Bistro/Browse?cuisine=Italian
        public ActionResult Browse(string cuisine)
        {
            Cuisine cuisineModel = new Cuisine (cuisine);

            return View(cuisineModel);
        }
        //
        // GET: /Bistro/Details/5
        public ActionResult Details(int id = 1)
        {
            Food food = new Food("Food " + id);

            return View(food);
        }
    }
}