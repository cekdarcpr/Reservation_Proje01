﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Reservation_Proje01.Models;

namespace Reservation_Proje01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        { 
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetList());
            return Json(jsonCity); 
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var valuesJson = JsonConvert.SerializeObject(destination);
            return Json(valuesJson);
        }


    }
}
