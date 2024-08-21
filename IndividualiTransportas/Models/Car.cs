using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Models
{
    public class Car : Vehicle
    {
        public int DoorCount { get; set; }

        public Car(string maker, string model, int year, int doorCount) : base (maker, model, year)
        {
            Maker = maker;
            Model = model;
            Year = year;
            DoorCount = doorCount;
        }
    }
}
