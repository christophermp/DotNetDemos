using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonModel person = new PersonModel();

           //List<PersonModel> people = new List<PersonModel>();

           // PersonModel person = new PersonModel();
           // person.firstName = "Christopher";
           // people.Add(person);

           // person = new PersonModel();
           // person.firstName = "Daria";
           // people.Add(person);

           // foreach (PersonModel p in people)
           // {
           //     Console.WriteLine(p.firstName);
           // }

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";

            do
            {
                Console.Write("What is your first name (or type exit to stop): ");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }

            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.ReadLine();
        }
    }
}
