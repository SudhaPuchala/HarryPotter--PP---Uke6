using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class HarryPotterCharacter
    {
      public string Name { get; set; }
      public string House { get; set; }
      public List<string> Inventory{ get; set; } = new List<string>();

      public HarryPotterCharacter(string name, string house)
      {
          Name = name;
          House = house;
      }

      public void Introduce()
      {
          Console.WriteLine($"I am {Name} from the {House}!!");
          
          
          if (Inventory.Count>0)
          {
              Console.WriteLine("I have these items");
                foreach (var item in Inventory)
                {
                  Console.WriteLine($"{item}");
                }
              
          }
          else
          {
              Console.WriteLine("No items!!");
          }


      }



    }
}
