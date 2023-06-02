using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using dotnetproject.Dtos.Character;
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
        public async Task<ActionResult<ServiceResponse <List<GetCharacterDto>>>> Get()
        {
            return Ok(await characterService.GetAllCharacters());
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult <ServiceResponse <GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(await characterService.GetCharacterById(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await characterService.AddCharacter(newCharacter));
        }
    }
}

