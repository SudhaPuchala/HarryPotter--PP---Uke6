using System.Threading.Channels;
using System.Xml.Linq;

namespace HarryPotter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Wizard World Of HarryPotter!!!");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Which house do you belong to?");
            string house = Console.ReadLine();


            var character = new HarryPotterCharacter(name, house);
            Console.WriteLine($"Welcome, {character.Name} from {character.House}!");
            character.Introduce();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Introduction");
                Console.WriteLine("2. Go to the Magic Shop");
                Console.WriteLine("3. Do some magic!");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        character.Introduce();
                        break;
                    case "2":
                        var shop = new MagicShop();
                        shop.ShowMenu(character);
                        break;
                    case "3":
                        DoMagic(character);
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

           

            static void DoMagic(HarryPotterCharacter character)
            {
                Console.WriteLine("TYPE A SPELL!!");
                Console.WriteLine("Available spells: Vingardium Leviosa , Hokus Pokus");
                string spell  = Console.ReadLine();

                switch(spell)
                {
                    case "Vingardium Leviosa":
                        Console.WriteLine("A feather starts to flow in the air!!");
                        break;
                    case "Hokus Pokus":
                        Console.WriteLine("Fireworks light up with sparks!!");
                        break;
                    default:
                        Console.WriteLine("Wrong Spell!!");
                        break;



                }
            }
            

        } 
    }
}
