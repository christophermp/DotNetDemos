using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Meldre");

            person.FirstName = "Christopher";
            //person.LastName = "Meldre";
            person.Age = 2;
            person.SSN = "123-45-6789";


            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            CityModel city = new CityModel();
            city.Address = "Vårliveien 13C";
            city.City = "Rygge";
            city.State = "Viken";
            city.ZipCode = 1580;

            Console.WriteLine(city.FullAddress);

            Console.ReadLine();
        }
    }
}
