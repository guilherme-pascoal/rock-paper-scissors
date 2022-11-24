using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Players 1: ");
            string p1 = Console.ReadLine();
            Console.Write("Players 2: ");
            string p2 = Console.ReadLine();

            string result = ResultRockPaperScissors(p1, p2);
            Console.WriteLine(result);
        }

        static string ResultRockPaperScissors(string p1, string p2)
        {
            if (p1 == p2) return "Draw!";

            int p = (p1 + p2) == "rockscissors" || (p1 + p2) == "scissorspaper" || (p1 + p2) == "paperrock" ? 1 : 2;
            return "Player " + p + " won!";
        }
    }
}
