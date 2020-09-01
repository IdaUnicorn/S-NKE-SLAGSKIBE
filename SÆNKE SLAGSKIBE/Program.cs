using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SÆNKE_SLAGSKIBE
{
    class Program
    {
        static void Main(string[] args)
        {
            string A1 = "A1";
            string B1 = "B1";
            string C1 = "C1";
            string D1 = "D1";
            string E1 = "E1";
           
            string[] slagskib1 = new string[5] { "A1", "B1", "C1", "D1", "E1" };

            string A2 = "A2";
            string B2 = "B2";
            string C2 = "C2";
            string D2 = "D2";
            string E2 = "E2";

            string[] slagskib2 = new string[5] { "A2", "B2", "C2", "D2", "E2" };

            string A3 = "A3";
            string B3 = "B3";
            string C3 = "C3";
            string D3 = "D3";
            string E3 = "E3";

            string[] slagskib3 = new string[5] { "A3", "B3", "C3", "D3", "E3" };

            string A4 = "A4";
            string B4 = "B4";
            string C4 = "C4";
            string D4 = "D4";
            string E4 = "E4";

            string[] slagskib4 = new string[5] { "A4", "B4", "C4", "D4", "E4" };

            string A5 = "A5";
            string B5 = "B5";
            string C5 = "C5";
            string D5 = "D5";
            string E5 = "E5";

            string[] slagskib5 = new string[5] { "A5", "B5", "C5", "D5", "E5" };
            
            foreach(string plads1 in slagskib1)
            {
                Console.Write(plads1 +" ");
            }
            Console.WriteLine();
            foreach (string plads2 in slagskib2)
            {
                Console.Write(plads2 + " ");
            }
            Console.WriteLine();
            foreach (string plads3 in slagskib3)
            {
                Console.Write(plads3 + " ");
            }
            Console.WriteLine();
            foreach (string plads4 in slagskib4)
            {
                Console.Write(plads4 + " ");
            }
            Console.WriteLine();
            foreach (string plads5 in slagskib5)
            {
                Console.Write(plads5 + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            string boat;
            Console.WriteLine("Enter the place of your boat ");
            boat = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your boat is placed at: " + boat);

            string bomb;
            Console.WriteLine("Place your bomb");
            bomb = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your boat is placed at: " + bomb);
            if (bomb == boat)
                Console.WriteLine("You lost the ship");
            else
                while (bomb != boat)
                {
                Console.WriteLine("Try again");
                Console.WriteLine("Place your bomb");
                bomb = Console.ReadLine();
                }
            Console.WriteLine("You lost the ship");
            Console.ReadKey();

            

        }
    }
}
