using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BattleRoyalGame
{
    public class CharacterService
    {
        private readonly BattleroyalDb _context;

       
       
        public CharacterService(BattleroyalDb context)
        {
            _context = context;
        }

        
            public SQLentity CreateCharacter(SQLentity character)
            {
                
                _context.Character.Add(character);
                _context.SaveChanges(); 
                return character;
            }

       
        public List<SQLentity> GetAllCharacters()
        {
            return _context.Character.ToList(); 
        }

        
        public SQLentity? GetCharacterById(string id)
        {
            return _context.Character.FirstOrDefault(c => c.ID == id); 
        }

        
        public bool DeleteCharacter(string id)
        {
            var character = _context.Character.FirstOrDefault(c => c.ID == id);
            if (character == null)
            {
                return false;
            }

            _context.Character.Remove(character);
            _context.SaveChanges(); 
            return true;
        }
        
        public bool HasAnyCharacter()
        {
            return _context.Character.Any();
        }
    }
}