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
            "What Variable Handles Numbers?",
            "",
            "Question3",
            "Question4",
            "Question5",
            "Question6",
            "Question7",
            "Question8",
            "Question9",
            "Question10"

        };

        static int[] Answers = { 1, 1, 3, 4, 2, 4, 2, 3, 1, 4};


        static string[,] Choices = new string[,]
        {
            { "Int", "String", "Char","Bool", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
            { "1", "2", "3","4", },
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
                    Console.Write("Correct!");
                    CorrectCount += 1;
                }
                else
                {
                    Console.Write("Wrong!");
                    WrongCount += 1;
                }

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

        static void QuestionStorage()
        {
            for(int AnswerRows = 0; AnswerRows < Choices.GetLength(0); AnswerRows++)
            {

            }


        }
    }
    
}
