using myapi.Models;
using myapi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public HelloController()
        {
        }

        [HttpGet]
        public string Get() => "Hello";
    }
}