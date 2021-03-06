using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseStock {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Cow");
            Console.WriteLine ("2. Ostrich");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            while (true) {
                string choice = Console.ReadLine();
                if  (int.TryParse(choice, out int i))
                {
                    switch (i)
                    {
                        case 1:
                            ChooseGrazingField.CollectInput(farm, new Cow());
                            break;
                        default:
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option selected");
                }
            }

        }
    }
}