using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE
{
    public class Villan : BaseCharacter
    {
        public new void CharacterSaysWhat()
        {
            Console.WriteLine("You were never going to prevail over me. I am hidden within your code, to bad you didn't use a breakpoint!");
        }
    }
}
