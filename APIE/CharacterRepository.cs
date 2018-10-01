using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE
{
    public class CharacterRepository : ICharacter
    {
        Random random = new Random();

        public List<string> bugList = new List<string>()
        {
            "Your first Bug", "Take 15 minutes and then come find me", "The Brain Twister", "Brainiac", "4 foot Moth", "You won't find me today"
        };

        public void Thinking()
        {
            BaseCharacter character = new BaseCharacter();
            character.CharacterSaysWhat();
        }

        public void HeroThinking()
        {
            Hero hero = new Hero();
            hero.CharacterSaysWhat();
        }

        public void BugThinking()
        {
            Villan villan = new Villan();
            villan.CharacterSaysWhat();
        }

        public List<string> BugList()
        {
            return bugList;
        }

        //public void VanquishBug(List<string> bugList)
        //{
        //    var removeBug = bugList.Remove(bugList);

        //}
    }
}
