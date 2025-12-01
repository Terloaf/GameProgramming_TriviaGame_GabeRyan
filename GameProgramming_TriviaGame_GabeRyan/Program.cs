using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_TriviaGame_GabeRyan
{
    internal class Program
    {
        static string Username = " ";

        static int QuestionNum;
        static int CorrectCount = 0;
        static int WrongCount = 0;
        static int QuestionOffset = 1;

        List<string> QuestionAnswers = new List<string>();

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


            PlayerInfo();
            for(QuestionNum = 0; QuestionNum < Questions.Length; QuestionNum++)
            {
                
                ShowHud();
                
                Console.WriteLine(Questions[QuestionNum]);

                for(int ChoicesLength = 0; ChoicesLength < Choices.GetLength(1); ChoicesLength++)
                {
                    Console.WriteLine(ChoicesLength + QuestionOffset + ". " + Choices[QuestionNum, ChoicesLength]);
                }
                Console.WriteLine("Answer: ");
                string Answer = Console.ReadLine();

                

                int GuessAsInt = int.Parse(Answer);
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
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }

            }
                
            if(CorrectCount == Questions.Length)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ Congrats On Getting Everything Correct! Heres A Certificate That Proves You Did It. ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                        ▒▒▒                                          ║");
                Console.WriteLine("║                                      ▒▒▒▒▒▒▒                                        ║");
                Console.WriteLine("║                                    ▒▒▒▒▒▒▒▒▒▒▒                                      ║");
                Console.WriteLine("║                                   ▒▒▒▒▒▒▒▒▒▒▒▒▒                                     ║");
                Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                    ║");
                Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                    ║");
                Console.WriteLine("║                                  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                    ║");
                Console.WriteLine("║                                   ▒▒▒▒▒▒▒▒▒▒▒▒▒                                     ║");
                Console.WriteLine("║                                     ▒▒▒▒▒▒▒▒▒                                       ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("║                                                                                     ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
            }






            
        }


        static void ShowHud()
        {
            Console.WriteLine("Name: " + Username);
            Console.WriteLine("Question: " + (QuestionNum + QuestionOffset));
            Console.WriteLine("Correct Answers: " + CorrectCount);
            Console.WriteLine("Wrong Answers: " + WrongCount);
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
