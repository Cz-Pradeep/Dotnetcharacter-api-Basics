using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dott.Nets_RPG.Models;

namespace Dott.Nets_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
       List<Character> GetAllCharacters();

       Character GetCharacterById(int id);
       
       List<Character> AddCharacter(Character newCharacter);
     

    }
}