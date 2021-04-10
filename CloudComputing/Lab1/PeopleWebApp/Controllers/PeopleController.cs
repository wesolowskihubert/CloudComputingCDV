using System;
using PeopleWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PeopleWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var people = new List<Person>
            {
                new Person{
                    FirstName = "Hubert",
                    LastName = "Wesołowski",
                    Id = 1
                }
            };
            return Ok(people);
        }
    }
}