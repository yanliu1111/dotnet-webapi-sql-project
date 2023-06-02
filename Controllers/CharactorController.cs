using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetproject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Name = "Sam" }
        };
        

        [HttpGet]
        [Route("GetAll")]
        public ActionResult <List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult <List<Character>> GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}

