using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_ef.Models;

namespace dotnet_ef.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAll();
        Task<ServiceResponse<Character>> GetById(int id);
        Task<ServiceResponse<List<Character>>> Add(Character newCharacter);
    }
}