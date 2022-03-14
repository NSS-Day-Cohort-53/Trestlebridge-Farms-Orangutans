using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IMeatProducing, IFeatherProducing, IEggProducing, IFeeding
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7; 
        private int _eggProduced = 7;
        private double _featherProduced = 0.5;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double FeedPerDay {get; set;} = 0.9;
        public string Type {get;} = "Chicken";

        public void Feed()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }
         public double Butcher () {
            return _meatProduced;
        }
         public int Collect()
        {
            return _eggProduced;
        }

        public double Pluck()
        {
            return _featherProduced;
        }
         public override string ToString () 
         {
            return $"Chicken {this._shortId}. Cluck Cluck Cluck!";
         }
        
        

        
    }
}