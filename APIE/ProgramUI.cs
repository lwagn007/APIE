using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE
{
    class ProgramUI
    {
        private CharacterRepository _charRepo = new CharacterRepository();
        Hero hero;

        public void Begin()
        {
            Console.WriteLine(@"
  ___ _ _   _      _ _         _    _            _     _ ___  _ ___    
 / ( | ) | | |    | | |       | |  | |          | |   | |__ \( | ) \ _ 
| | V V| |_| | ___| | | ___   | |  | | ___  _ __| | __| |  ) |V V | (_)
| |    |  _  |/ _ \ | |/ _ \  | |/\| |/ _ \| '__| |/ _` | / /     | |  
| |    | | | |  __/ | | (_) | \  /\  / (_) | |  | | (_| ||_|      | |_ 
| |    \_| |_/\___|_|_|\___/   \/  \/ \___/|_|  |_|\__,_|(_)      | ( )
 \_\                                                             /_/|/ 
                                                                       
 ");
            Console.ReadKey();
            InitialDialogue();
        }

        private void Menu()
        {
            ShowMenu();

            bool run = true;
            while (run)
            {
                int choice = ParseInput();

                switch (choice)
                {
                    case 1:
                        CreateCharacter();
                        break;
                }
            }
        }

        private void SecondMenu()
        {
            Console.Clear();
            ShowMenuTwo();

            bool run = true;
            while (run)
            {
                int choice = ParseInput();

                switch (choice)
                {
                    case 1:
                        CharacterDetail();
                        break;
                    case 2:
                        _charRepo.Thinking();
                        break;
                    case 3:
                        _charRepo.HeroThinking();
                        break;
                    case 4:
                        _charRepo.BugThinking();
                        break;
                    case 5:
                        BugList();
                        break;
                    case 6:
                        VanquishBug();
                        break;
                    case 7:
                        Console.Clear();
                        run = false;
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1.Create Character");
        }

        private void ShowMenuTwo()
        {
            Console.Clear();
            Console.WriteLine("1. Character Details\r\n" +
                "2. What You Are Thinking Going Into Programming \r\n" +
                "3. What You Think When You Delete a Bug \r\n" +
                "4. What a Bug Thinks When You Fail to Demolish it\r\n" +
                "5. Bugs To Vanquish \r\n" +
                "6. Vanquish Bug \r\n" +
                "7. Exit");
        }

        private void InitialDialogue()
        {
            Console.Clear();
            bool yes = true;
            while (yes)
            {
                Console.WriteLine("You feel a little bit like Alice...Tumbling down the rabbit hole...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Let me tell you why you are here. You're here because you know something. What you know, you can't explain. But you FEEL it. You have felt it your entire life, or at least the last 3 months...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("You have felt that there is something wrong with the world. You don't know what it is, but its there...like a splinter in your mind, driving you mad. It is this feeling that has brought you here. Do you know what I'm talking about?");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("I am talking about the bugs that invade your code. Hidden in the darkness, driving you mad to destroy them. I will teach you what to do...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("I will offer you a chance to leave...if you don't leave now you must continue");
                Console.WriteLine("Would you like to continue? yes or no");

                string stringInput = Console.ReadLine();
                if (stringInput.ToLower() == "yes")
                {
                    yes = true;
                    Menu();
                }
                else
                {
                    break;
                }
            }
        }

        public void CreateCharacter()
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            string characterName = Console.ReadLine();

            Console.WriteLine("How strong is your struggle muscle? Enter a number between 1 and 10");
            int lives = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is your profession?");
            string profession = Console.ReadLine();

            hero = new Hero(characterName, lives, profession);

            Console.WriteLine("Character has been created.");
            SecondMenu();
        }

        private void CharacterDetail()
        {
            Console.WriteLine($"Your name is: {hero.Name}\r\n" +
                $"You are a: {hero.Profession}\r\n" +
                $"Your struggle muscle strength is: {hero.StruggleMuscle}\r\n");
            SecondMenu();
        }

        private void BugList()
        {
            Console.Clear();
            Console.WriteLine("Bug Names:");
            List<string> bugList = _charRepo.BugList();
            foreach(string bug in bugList)
            {
                Console.WriteLine(bug);
            }
            Console.ReadLine();
            Console.Clear();
            SecondMenu();
        }

        //private void RemoveBug()
        //{
        //    Console.Clear();
        //    Console.WriteLine("What bug would you like to vanquish? Please write name:");
        //    var bugNameInput = Console.ReadLine();
        //    _charRepo.VanquishBug(bugNameInput);
        //    VanquishBug();
        //}

        private void VanquishBug()
        {
            Console.Clear();
            Console.WriteLine("You conquerored a bug!");
            Console.WriteLine($"{hero.Name} says:");
            hero.CharacterSaysWhat();
        }
        
        private int ParseInput()
        {
            int value;
            while (true)
            {
                var valueAsString = Console.ReadLine();
                if (Int32.TryParse(valueAsString, out value)) break;
                else Console.WriteLine("Please enter a valid number...");
            }
            return value;
        }
    }
}
