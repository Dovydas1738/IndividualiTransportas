using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string maker, string model, int year)
        {
            Maker = maker;
            Model = model;
            Year = year;
        }
    }
}
