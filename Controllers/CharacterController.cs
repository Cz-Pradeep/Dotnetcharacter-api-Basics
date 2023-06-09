using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dott.Nets_RPG.Models;

using Microsoft.AspNetCore.Mvc;

namespace Dott.Nets_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
     
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
     {
            _characterService = characterService;
        }


       [HttpGet("GetAll")]
       public ActionResult<List<Character>> Get()
       {
        return Ok(_characterService.GetAllCharacters());
       }

    [HttpGet("{id}")]
       public ActionResult<Character> GetSingle(int id)
       {
        return Ok(_characterService.GetCharacterById(id));
       }

       [HttpPost]
       public ActionResult<List<Character>> AddCharacter(Character newCharacter)
       {
            
               return Ok(_characterService.AddCharacter(newCharacter));
               
       }

       
    }
}