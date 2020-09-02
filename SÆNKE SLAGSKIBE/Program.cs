using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SÆNKE_SLAGSKIBE
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("My area:");
            string[] slagskibsplade_min = new string[25] { " A1", "B1", "C1", "D1", "E1\n", "A2", "B2", "C2", "D2", "E2\n", "A3", "B3", "C3", "D3", "E3\n", "A4", "B4", "C4", "D4", "E4\n", "A5", "B5", "C5", "D5", "E5" };            
            
            List<string> allefelter_min = new List<string>();

            foreach (string plads1 in slagskibsplade_min)
            {
                Console.Write(plads1 + " ");
                allefelter_min.Add(plads1);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("My opponents area:");
            string[] slagskibsplade_modstander = new string[25] { " F1", "G1", "H1", "I1", "J1\n", "F2", "G2", "H2", "I2", "J2\n", "F3", "G3", "H3", "I3", "J3\n", "F4", "G4", "H4", "I4", "J4\n", "F5", "G5", "H5", "I5", "J5" };

            List<string> allefelter_modstander = new List<string>();

            foreach (string plads2 in slagskibsplade_modstander)
            {
                Console.Write(plads2 + " ");
                allefelter_modstander.Add(plads2);
            }

            Console.WriteLine();
            Console.WriteLine();
            string boat_mine; //jeg placerer min båd
            Console.WriteLine("Enter the place of your boat ");
            boat_mine = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your boat is placed at: " + boat_mine);

            Random rnd = new Random(); //PC placerer sin båd et tilfældigt sted på sin plade.
            List<Slagskib> heleliste = new List<Slagskib>(); //laver ny liste
            string skib_modstander = slagskibsplade_modstander[rnd.Next(0, 25)];

            string bomb_mine;
            Console.WriteLine("Place your bomb"); //Jeg bomber min modstander.
            bomb_mine = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your boat is placed at: " + bomb_mine);

            List<Bombe> heleliste2 = new List<Bombe>(); //laver ny liste
            string bombe_modstander = slagskibsplade_min[rnd.Next(0, 25)]; //modstander bomber mig



            while (bombe_modstander != boat_mine && bomb_mine != skib_modstander)
            {
                Console.WriteLine("Try again");
                Console.WriteLine("Place your bomb");
                bomb_mine = Console.ReadLine();

                Console.WriteLine("Now the PC will bomb you");
                bombe_modstander = slagskibsplade_min[rnd.Next(0, 25)]; //modstander bomber mig
            }
            if (bombe_modstander == boat_mine)
                Console.WriteLine("I lost and the PC won ! !, the PC placed its ship at: " + skib_modstander);
            
            else
                Console.WriteLine("I won and the PC lost ! !, the PC placed its ship at: " + skib_modstander);
                Console.WriteLine();
                Console.WriteLine();
            Console.ReadKey();
        }

    }
}