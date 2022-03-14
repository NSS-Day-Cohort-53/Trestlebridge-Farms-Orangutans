using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IEggProducing, IFeatherProducing, IFeeding
    {

        private Guid _id = Guid.NewGuid();
        private int _eggProduced = 6;
        private double _featherProduced = 0.75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.8;
        public string Type { get; } = "Cow";

        // Methods
        public void Feed()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public int Collect()
        {
            return _eggProduced;
        }

        public double Pluck()
        {
            return _featherProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. quaaack!";
        }
    }
}