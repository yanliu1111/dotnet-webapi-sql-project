using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using dotnetproject.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetproject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService characterService;

        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }
         
        [HttpGet("GetAll")]
        public ActionResult <List<Character>> Get()
        {
            return Ok(characterService.GetAllCharacters());
        }

        [HttpGet ("{id}")]
        public ActionResult <List<Character>> GetSingle(int id)
        {
            return Ok(characterService.GetCharacterById(id));
        }
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(characterService.AddCharacter(newCharacter));
        }
    }
}

