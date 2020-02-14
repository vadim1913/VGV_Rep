﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIDStatisticsAPI.Controllers
{
    [ApiController]
    [Route("api/cities")]

    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }
             

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
           return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));                       
        }
    }
}

