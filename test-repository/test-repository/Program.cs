using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bato_Bato_Pic
{
    class Program
    {
        static void Main(string[] args)
        {

            int retry = 1;
            int difficulty;
            Console.WriteLine("Choose Difficulty");
            Console.WriteLine("[1] - Easy");
            Console.WriteLine("[2] - Hard");
            int.TryParse(Console.ReadLine(), out difficulty);
            if (difficulty == 1)
            {

                while (retry == 1)
                {
                    Console.Clear();
                    int retryChoice = 0;
                    int choice;
                    string you = "";
                    Easy game = new Easy();

                    Console.WriteLine("[1] - Rock");
                    Console.WriteLine("[2] - Paper");
                    Console.WriteLine("[3] - Scissors");
                    Console.Write("Enter choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice == 1)
                    {
                        you = "Rock";
                    }
                    else if (choice == 2)
                    {
                        you = "Paper";
                    }
                    else if (choice == 3)
                    {
                        you = "Scissors";
                    }
                    Console.WriteLine("You: " + you + " vs. " + "CPU: " + game.cpuChoice());
                    Console.WriteLine(game.shoot(choice));
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Try again?");
                    Console.WriteLine("[1] - Yes");
                    Console.WriteLine("[2] - No");
                    int.TryParse(Console.ReadLine(), out retryChoice);
                    if (retryChoice == 2)
                    {
                        retry = 0;
                    }
                    else
                    {
                        retry = 1;
                    }


                } //while
            }
            else if (difficulty == 2)
            {
                while (retry == 1)
                {

                    Console.Clear();
                    int retryChoice = 0;
                    int choice = 0;
                    string you = "";
                    Hard game2 = new Hard();
                    Console.WriteLine(game2.choi());
                    Console.WriteLine("[1] - Rock");
                    Console.WriteLine("[2] - Paper");
                    Console.WriteLine("[3] - Scissors");
                    Console.Write("Enter choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                    if (choice == 1)
                    {
                        you = "Rock";
                    }
                    else if (choice == 2)
                    {
                        you = "Paper";
                    }
                    else if (choice == 3)
                    {
                        you = "Scissors";
                    }
                    game2.shoot2(choice);
                    Console.WriteLine("You: " + you + " vs. " + "CPU: " + game2.getCpu());
                    Console.WriteLine("You LOSE");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Try again?");
                    Console.WriteLine("[1] - Yes");
                    Console.WriteLine("[2] - No");
                    int.TryParse(Console.ReadLine(), out retryChoice);
                    if (retryChoice == 2)
                    {
                        retry = 0;
                    }
                    else
                    {
                        retry = 1;
                    }

                } //while
            }
        }//main
    }

    class Easy
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        string cpu;
        int choice;
        Random rand = new Random();

        public Easy()
        {
            choice = rand.Next(0, 3);
            cpu = choices[choice];
        }
        public string shoot(int choice)
        {
            if (choice == 1 && cpu == choices[2] || choice == 2 && cpu == choices[0] || choice == 3 && cpu == choices[1])
            {
                return "You WIN!!!";
            }
            else if (choice == 1 && cpu == choices[0] || choice == 2 && cpu == choices[1] || choice == 3 && cpu == choices[2])
            {
                return "TIE. Try again...";
            }
            else
            {
                return "You LOSE";
            }
        }

        public string cpuChoice()
        {
            return this.cpu;
        }
    }

    class Hard
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        string cpu;



        public Hard()
        {

        }

        public void shoot2(int choice)
        {
            if (choice == 1)
            {
                cpu = choices[1];
            }
            else if (choice == 2)
            {
                cpu = choices[2];
            }
            else if (choice == 3)
            {
                cpu = choices[0];
            }
        }
        public string getCpu()
        {
            return this.cpu;
        }

        public string choi()
        {
            string ch = "";
            for (int i = 0; i < choices.Length; i++)
            {
                ch += choices[i] + " ";
            }

            return ch;
        }

    }
}
