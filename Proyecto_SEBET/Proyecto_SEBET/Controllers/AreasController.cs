﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_SEBET.Models;

namespace Proyecto_SEBET.Controllers
{
    public class AreasController : Controller
    {
        private IRepository repository;

        public AreasController(IRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InsertArea(Area area)
        {
            repository.AddArea(area);
            return RedirectToAction(nameof(Index));
        }

    }
}