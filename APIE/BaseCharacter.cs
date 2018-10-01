using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE
{
    public class BaseCharacter
    {
        public string Name { get; set; }
        public int StruggleMuscle { get; set; }

        public virtual void CharacterSaysWhat()
        {
            Console.WriteLine("I am not sure what programming holds in store for me, it shouldn't be to hard.");
        }
    }
}
