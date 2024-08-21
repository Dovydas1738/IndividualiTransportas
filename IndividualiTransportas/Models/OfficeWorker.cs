using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Models
{
    public class OfficeWorker : Worker
    {
        public string Department {  get; set; }

        public OfficeWorker(string name, string surname, int age, string department) : base(name,surname,age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Department = department;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, age: {Age}, department - {Department}";
        }

    }
}
