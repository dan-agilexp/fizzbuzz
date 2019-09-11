using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.API.Controllers
{
    using FizzBuzz.API.Services;

    using Microsoft.AspNetCore.Routing.Template;

    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private IFizzBuzzService fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
           this.fizzBuzzService = fizzBuzzService;
        }

        [HttpGet]
        [Route("{id}")]
        public string GetFizzBuzz([FromRoute]int id)
        {
            var result = this.fizzBuzzService.GetFizzBuz(id);
            return result;
        }
    }
}