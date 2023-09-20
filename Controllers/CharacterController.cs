using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_ef.Models;
using dotnet_ef.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly CharacterService _characterService;

        public CharacterController(CharacterService characterService)
        {
            _characterService = characterService;
            
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> Get(){
            return Ok(await _characterService.GetAll());
        }

        // Add the ID parameter
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingleCharacter(int id){
            return Ok(await _characterService.GetById(id));
        }

        // Body parameters are sent in the method parameters
        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter){
            return Ok(await _characterService.Add(newCharacter));
        }
    } 
}