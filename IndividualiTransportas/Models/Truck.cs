using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Models
{
    public class Truck : Vehicle
    {
        public int MaxLoad { get; set; }

        public Truck(string maker, string model, int year, int maxLoad) : base(maker, model, year)
        {
            Maker = maker;
            Model = model;
            Year = year;
            MaxLoad = maxLoad;

        }

        public override string ToString()
        {
            return $"{Maker} {Model} {Year} Max load: {MaxLoad} kg.";
        }
    }
}
