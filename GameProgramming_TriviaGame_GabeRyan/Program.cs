using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_TriviaGame_GabeRyan
{
    internal class Program
    {
        static bool Playing = false;
        static string Username = " ";
        static void Main(string[] args)
        {
            PlayerInfo();
            while (Playing == true)
            {
                ShowHud();
            }






            
        }


        static void ShowHud()
        {
            Console.Write("Name: " + Username);
        }

        static void PlayerInfo()
        {
            Console.WriteLine("Enter Name: ");
            Username = Console.ReadLine();
            Playing = true;
        }
    }
}
