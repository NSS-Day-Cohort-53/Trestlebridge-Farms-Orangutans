using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IResource animal)
        {
            Utils.Clear();

            while (true) {     
                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    //make sure we have a farm for that choice
                    if (choice < 1 || choice > farm.GrazingFields.Count)
                    {
                        Console.WriteLine($"Invalid option selected {choice}");
                    } else
                    {
                        farm.PurchaseResource<IGrazing>(animal, choice - 1);
                        break;
                    }
                } catch(FormatException)
                {
                    Console.WriteLine($"Invalid option selected");
                }
            }
        }
    }
}