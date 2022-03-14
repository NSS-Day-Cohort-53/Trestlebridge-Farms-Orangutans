using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IFeeding>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IFeeding> _animals = new List<IFeeding>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IFeeding animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<IFeeding> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}