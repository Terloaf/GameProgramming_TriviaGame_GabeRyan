using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_TriviaGame_GabeRyan
{
    internal class Program
    {
        static string Username = " ";
        static bool PlayerProfile = true;

        static int QuestionNum;
        static int CorrectCount = 0;
        static int WrongCount = 0;
        static int QuestionOffset = 1;
        static int Score = 100;
        static int WrongMultiplier = 10;
        static int MinimumCharLength = 1;
        static int ChoicesLength = 0;
        static int GuessAsInt;
        static string Answer;

        static string[] Questions =
            {
            "What Variable Handles Humbers?",
            "What Does && Mean In C#?",
            "What Language Does Unity Use",
            "What Question Is This?",
            "What KeyWord Skips A Method?",
            "What Do You Call A Number That Isnt Assigned To Any Variable?",
            "What Colour Do Numbers Show Up As In Visual Studio C#",
            "How Many Fingers Does The Average Person Have On One Hand?",
            "What Does || Mean In C#?",
            "What Should You Always Use To Make Sure You Dont Lose Your Projects?"

        };

        static int[] Answers = { 1, 1, 3, 4, 2, 4, 2, 3, 1, 4};


        static string[,] Choices = new string[,]
        {
            { "Int", "String", "Char", "Bool", },
            { "And", "Then", "Or", "Nothing", },
            { "Python", "Java", "C#","Lua", },
            { "1", "2", "3","4", },
            { "Break", "Return", "Stop","End", },
            { "Normal", "Floating", "Default","Magic", },
            { "Red", "Green", "Blue","Orange", },
            { "3", "6", "5","10", },
            { "Or", "And", "But","Then", },
            { "Word", "Memory", "VisualStudio","GitHub", },
        };


        static void Main(string[] args)
        {


            while(PlayerProfile == true)
            {
                PlayerInfo();
                if(Username.Length >= MinimumCharLength)
                {
                    PlayerProfile = false;
                }

                if (Username == "Easter")
                {
                    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║ Heres An Egg.                                                                       ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                        ▒▒▒                                          ║");
                    Console.WriteLine("║                                      ▒▒▒▒▒▒▒                                        ║");
                    Console.WriteLine("║                                    ▒▒░░▒▒▒▒▒▒▒                                      ║");
                    Console.WriteLine("║                                   ▒▒░░▒▒▒▒▒▒▒▒▒                                     ║");
                    Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                    ║");
                    Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒░░▒                                    ║");
                    Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒░░░▒                                    ║");
                    Console.WriteLine("║                                   ▒▒▒▒▒▒▒▒░░░▒▒                                     ║");
                    Console.WriteLine("║                                     ▒▒▒▒▒▒▒▒▒                                       ║");
                    Console.WriteLine("║                                                                                     ║");
                    Console.WriteLine("║                                                                     It's Easter-ish.║");
                    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");

                    PlayerProfile = true;

                }
            }
                

            if (Username == "Easter")
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Heres An Egg.                                                                       ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                        ▒▒▒                                          ║");
                Console.WriteLine("║                                      ▒▒▒▒▒▒▒                                        ║");
                Console.WriteLine("║                                    ▒▒░░▒▒▒▒▒▒▒                                      ║");
                Console.WriteLine("║                                   ▒▒░░▒▒▒▒▒▒▒▒▒                                     ║");
                Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                    ║");
                Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒░░▒                                    ║");
                Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒░░░▒                                    ║");
                Console.WriteLine("║                                   ▒▒▒▒▒▒▒▒░░░▒▒                                     ║");
                Console.WriteLine("║                                     ▒▒▒▒▒▒▒▒▒                                       ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                     It's Easter-ish.║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");

                
                
            }
            for (QuestionNum = 0; QuestionNum < Questions.Length; QuestionNum++)
            {
                
                ShowHud();
                
                Console.WriteLine(Questions[QuestionNum]);

                for(ChoicesLength = 0; ChoicesLength < Choices.GetLength(1); ChoicesLength++)
                {
                    Console.WriteLine(ChoicesLength + QuestionOffset + ". " + Choices[QuestionNum, ChoicesLength]);
                }
                Console.WriteLine("Answer: ");
                
               
                while (Answer != "1" || Answer != "2"|| Answer != "3" || Answer != "4")
                {
                    Answer = Console.ReadLine();

                    if(Answer == "1" || Answer == "2" || Answer == "3" || Answer == "4")
                    {
                        GuessAsInt = int.Parse(Answer);
                        break;
                    }
                    
                    Console.WriteLine("Please Add A Valid Answer");
                }
            
                

                if (GuessAsInt == Answers[QuestionNum])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Correct!");
                    CorrectCount += 1;
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Wrong!");
                    WrongCount += 1;
                    Score -= WrongCount * WrongMultiplier;
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
                

            }
                
            if(CorrectCount == Questions.Length)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You Got Everything Correct!!!");
            }






            
        }


        static void ShowHud()
        {
            
            Console.WriteLine("Name: " + Username);
            Console.WriteLine("Question: " + (QuestionNum + QuestionOffset));
            Console.WriteLine("Correct Answers: " + CorrectCount);
            Console.WriteLine("Wrong Answers: " + WrongCount);
            Console.WriteLine("Score: " + Score + "%");
            Console.ReadKey();
            Console.Clear();


        }

        static void PlayerInfo()
        {
            Console.WriteLine("Enter Name: ");
            Username = Console.ReadLine();
            Console.Clear();
        }

    }
    
}
