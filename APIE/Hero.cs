using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE
{
    public class Hero : BaseCharacter
    {
        public Hero()
        {

        }

        public Hero(string name, int struggleMuscle, string profession)
        {
            Name = name;
            StruggleMuscle = struggleMuscle;
            Profession = profession;
        }

        public string Profession { get; set; }

        public new void CharacterSaysWhat()
        {
            Console.WriteLine("I am the best, thank you!");
        }
    }
}
