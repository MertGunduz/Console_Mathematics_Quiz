using System;
using System.Threading;

namespace Console_Mathematics_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
        MAINMENU:
            try
            {
                int number1, number2, number3, number4;
                int sumNumbers;
                int yourAnswer;
                int quizPoints = 0;
                string difficultyChoice;
                Random randomEnumerator = new Random();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("| Mathematics Quiz Console Application |");
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine(" ");

                Console.WriteLine("|------------------------|");
                Console.WriteLine("| [Easy]-[Medium]-[Hard] |");
                Console.WriteLine("|------------------------|");
                Console.WriteLine(" ");

                Console.Write("Choose Difficulty: ");
                difficultyChoice = Console.ReadLine();
                Console.WriteLine(" ");
                Console.ResetColor();

                if (difficultyChoice == "Easy" || difficultyChoice == "easy" || difficultyChoice == "EASY")
                {
                    for (int i = 0; i <= 1000; i++)
                    {
                        number1 = randomEnumerator.Next(1, 100);
                        number2 = randomEnumerator.Next(1, 100);
                        sumNumbers = number1 + number2;
                        Console.WriteLine(number1 + " + " + number2);
                        Console.WriteLine(" ");
                        Console.Write("Enter Your Answer: ");
                        yourAnswer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        if (quizPoints == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("|-----------------------|");
                            Console.WriteLine("| You Win The Easy Mode |");
                            Console.WriteLine("|-----------------------|");
                            Console.ResetColor();
                            break;
                        }
                        else if (quizPoints == -10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|------------------------|");
                            Console.WriteLine("| You Lost The Easy Mode |");
                            Console.WriteLine("|------------------------|");
                            Console.ResetColor();
                            break;
                        }
                        if (yourAnswer == sumNumbers)
                        {
                            quizPoints++;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("|------|");
                            Console.WriteLine("| True |");
                            Console.WriteLine("|------|");
                            Console.WriteLine(" ");
                            Console.WriteLine("Points: " + quizPoints);
                            Console.WriteLine(" ");
                            Console.ResetColor();
                        }
                        else
                        {
                            quizPoints--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|-------|");
                            Console.WriteLine("| False |");
                            Console.WriteLine("|-------|");
                            Console.WriteLine(" ");
                            Console.WriteLine("Points: " + quizPoints);
                            Console.WriteLine(" ");
                            Console.ResetColor();
                        }
                    }
                }
                else if (difficultyChoice == "Medium" || difficultyChoice == "medium" || difficultyChoice == "MEDIUM")
                {
                    for (int i = 0; i <= 1000; i++)
                    {
                        number1 = randomEnumerator.Next(1, 100);
                        number2 = randomEnumerator.Next(1, 100);
                        number3 = randomEnumerator.Next(1, 100);
                        sumNumbers = number1 + number2 + number3;

                        Console.WriteLine(number1 + " + " + number2 + " + " + number3);
                        Console.WriteLine(" ");
                        Console.Write("Enter Your Answer: ");
                        yourAnswer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        if (quizPoints == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("|-------------------------|");
                            Console.WriteLine("| You Win The Medium Mode |");
                            Console.WriteLine("|-------------------------|");
                            Console.ResetColor();
                            break;
                        }
                        else if (quizPoints == -10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|--------------------------|");
                            Console.WriteLine("| You Lose The Medium Mode |");
                            Console.WriteLine("|--------------------------|");
                            Console.ResetColor();
                            break;
                        }
                        if (yourAnswer == sumNumbers)
                        {
                            quizPoints++;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("|------|");
                            Console.WriteLine("| True |");
                            Console.WriteLine("|------|");
                            Console.WriteLine(" ");
                            Console.WriteLine("Points: " + quizPoints);
                            Console.WriteLine(" ");
                            Console.ResetColor();
                        }
                        else
                        {
                            quizPoints--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|-------|");
                            Console.WriteLine("| False |");
                            Console.WriteLine("|-------|");
                            Console.WriteLine(" ");
                            Console.WriteLine("Points: " + quizPoints);
                            Console.WriteLine(" ");
                            Console.ResetColor();
                        }
                    }
                }
                else if (difficultyChoice == "Hard" || difficultyChoice == "hard" || difficultyChoice == "HARD")
                {
                    for (int i = 0; i <= 1000; i++)
                    {
                        number1 = randomEnumerator.Next(1, 100);
                        number2 = randomEnumerator.Next(1, 100);
                        number3 = randomEnumerator.Next(1, 100);
                        number4 = randomEnumerator.Next(1, 100);
                        sumNumbers = number1 + number2 + number3 + number4;

                        Console.WriteLine(number1 + " + " + number2 + " + " + number3 + " + " + number4);
                        Console.WriteLine(" ");
                        Console.Write("Enter Your Answer: ");
                        yourAnswer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        if (quizPoints == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("|-----------------------|");
                            Console.WriteLine("| You Win The Hard Mode |");
                            Console.WriteLine("|-----------------------|");
                            Console.ResetColor();
                            break;
                        }
                        else if (quizPoints == -10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|------------------------|");
                            Console.WriteLine("| You Lose The Hard Mode |");
                            Console.WriteLine("|------------------------|");
                            Console.ResetColor();
                            break;
                        }
                        if (yourAnswer == sumNumbers)
                        {
                            quizPoints++;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("|------|");
                            Console.WriteLine("| True |");
                            Console.WriteLine("|------|");
                            Console.WriteLine(" ");
                            Console.WriteLine("Points: " + quizPoints);
                            Console.WriteLine(" ");
                            Console.ResetColor();
                        }
                        else
                        {
                            quizPoints--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|-------|");
                            Console.WriteLine("| False |");
                            Console.WriteLine("|-------|");
                            Console.WriteLine(" ");
                            Console.WriteLine("Points: " + quizPoints);
                            Console.WriteLine(" ");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|-----------------------------|");
                    Console.WriteLine("| Undefined Difficulty Choice |");
                    Console.WriteLine("|-----------------------------|");
                    Console.WriteLine(" ");
                    Console.WriteLine("|--------------------------------------|");
                    Console.WriteLine("| Please Choice [Easy]-[Medium]-[Hard] |");
                    Console.WriteLine("|--------------------------------------|");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                    goto MAINMENU;
                }

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ");
                Console.WriteLine("|-------------------|");
                Console.WriteLine("| System Recovering |");
                Console.WriteLine("|-------------------|");
                Console.WriteLine(" ");
                Console.WriteLine("|-------------------|");
                Console.WriteLine("| Only Use Integers |");
                Console.WriteLine("|-------------------|");
                Console.WriteLine(" ");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                goto MAINMENU;
            }

        CONTROLMENU:
            string againOrExit;
            Console.WriteLine(" ");
            Console.WriteLine("To Try Again, Enter --> [1]");
            Console.WriteLine("To Exit The Program, Enter --> [0]");
            Console.WriteLine(" ");
            Console.Write("Answer: ");
            againOrExit = Console.ReadLine();
            Console.WriteLine(" ");

            if (againOrExit == "1")
            {
                Console.Clear();
                goto MAINMENU;
            }
            else if (againOrExit == "0")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("| Program Shutting Down |");
                Console.WriteLine("|-----------------------|");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|-------------------------------------------|");
                Console.WriteLine("| Undefined Choice Please Check Your Choice |");
                Console.WriteLine("|-------------------------------------------|");
                Console.ResetColor();
                Thread.Sleep(2000);
                goto CONTROLMENU;
            }
            Console.ReadLine();
        }
    }
}