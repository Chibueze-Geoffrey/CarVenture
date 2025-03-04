﻿using EzeCarVentures.Models;
using EzeCarVentures.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EzeCarVentures.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICar _carRepo;
        private readonly IBrand _brandRepo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ICar carRepo, IBrand brandRepo, ILogger<HomeController> logger)
        {
            _carRepo = carRepo;
            _brandRepo = brandRepo;
            _logger = logger;
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public ViewResult Index(string brand)
        {
            IEnumerable<Car> cars;
            string currentBrand;

            if (!string.IsNullOrEmpty(brand))
            {
                cars = _carRepo.AllCars
                    .Where(p => p.Brand != null && p.Brand.BrandName.Equals(brand, System.StringComparison.OrdinalIgnoreCase))
                    .OrderBy(p => p.BrandId);
            }
            else
            {
                cars = _carRepo.AllCars.OrderBy(p => p.BrandId);
            }

            var brandEntity = _brandRepo.AllBrand.FirstOrDefault(c => c.BrandName == brand);
            currentBrand = brandEntity != null ? brandEntity.BrandName : "All Cars";

            return View(new CarViewModel
            {
                Cars = cars,
                CurrentBrand = currentBrand
            });
        }

        public IActionResult Details(int id)
        {
            var car = _carRepo.GetCarById(id);
            if (car == null)
                return NotFound();

            return View(car);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Locations()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
