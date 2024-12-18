using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class MagicShop
    {
        public void ShowMenu(HarryPotterCharacter character)
        {
            Console.WriteLine("Welcome to the magic Shop! What would you like to buy?");
            Console.WriteLine("1. Pet(Owl, Rat, Cat)");
            Console.WriteLine("2. Wand(Phoenix Wand, Unicorn Wand, Magic Wand)");
            Console.WriteLine("3.Exit");

            while (true)
            {
                Console.WriteLine("Choose an option(1-3:");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        BuyPet(character);
                        break;
                    case "2":
                        BuyWand(character);
                        break;
                    case "3":
                        Console.WriteLine("Thanks for visiting!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;


                }


            }
        }

        public void BuyPet(HarryPotterCharacter character)
        {
            Console.WriteLine("Which pet do you like to buy? (Owl, Rat, Cat)");
            string pet = Console.ReadLine();

            if (pet == "Owl"|| pet == "Rat" || pet == "Cat" )
            { character.Inventory.Add(pet);
                Console.WriteLine($"You have bought a {pet}!");
            }
            else
            {
                Console.WriteLine("This pet is not available!!");
            }
        }

        public void BuyWand(HarryPotterCharacter character)
        {
            Console.WriteLine("Which wand would you like to buy?(Phoenix Wand, Unicorn Wand, Magic wand)");
            string wand = Console.ReadLine();
            if (wand == "Phoenix Wand" || wand == "Unicorn Wand" || wand == "Magic Wand")
            {
                character.Inventory.Add(wand);
                Console.WriteLine($"You have bought this {wand}");
            }
            else
            {
                Console.WriteLine("The wand is not available.");
            }

        }
        

        }


    }

