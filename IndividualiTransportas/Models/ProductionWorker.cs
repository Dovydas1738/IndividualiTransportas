using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Models
{
    public class ProductionWorker : Worker
    {
        public string Shift {  get; set; }


        public ProductionWorker(string name, string surname, int age, string shift) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Shift = shift;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, age: {Age}, shift - {Shift}";
        }

    }
}
