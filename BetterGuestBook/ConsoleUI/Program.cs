using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

// Capture information about each guest
// First name, Last name, message to host
// Once done, loop through each guest and print their info.

namespace ConsoleUI
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }


        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                //guest.FirstName = Console.ReadLine();

                guest.LastName = GetInfoFromConsole("What is your last name: ");
                //guest.LastName = Console.ReadLine();

                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host:");
                //guest.MessageToHost = Console.ReadLine();

                moreGuestsComing = GetInfoFromConsole("Is more guests coming (yes/no): ");
                //moreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
