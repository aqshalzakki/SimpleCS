// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Simple
{
    class Simple
    {
        static int Main(string[] args)
        {
            //WhileLoopGuessingGame();
            //ForLoop();
            //Console.WriteLine(GetPow(10, 7));
            //DimensionalArray();
            //TryCatch();

            //Class and methods 
            //Student student = new Student("Muhammad Aqshal Zakki", "Software Engineering", 3.4);
            //Student student2 = new Student("John Doe", "Hardware Engineering", 3.6);

            //Console.WriteLine($"{student.name} has honors? {student.HasHonors()}");

            //Getters and Setters
            //Player player1 = new Player("Maysomething", 100, 7, "support");
            //Player player2 = new Player("Ucok_Gorok", 100, 7, "fighter");
            //Console.WriteLine(player1.Role);

            //Static 
            //Console.WriteLine(Player.roles[1]);
            //Console.WriteLine(Util.IsEven(21));
            //return 0;

            //Inheritance
            //Vehicle vehicle = new Vehicle(150, 230);
            //Car car = new Car(200, 100, "Honda");
            //car.Onward(49);

            //Lambda
            //Func<string, string> intro = name => { return $"Hello! my name is {name}"; };
            //Func<int, int> doubleIt = x => x * 2
            //Console.WriteLine(intro("Aqshal Zakki"));
            //Console.WriteLine(doubleIt(20));

            //Array List
            ArrayList users = new ArrayList();
            users.Add("Aqshal Zakki");
            users.Add("Asep");
            users.Add("Ujang");
            users.Sort();
            users.Insert(1, "John");
            Console.WriteLine(users.IndexOf("Ujang"));
            Console.WriteLine(users[3]);

            foreach (var user in users) {
                Console.WriteLine($"My name is {user}");
            }

            return 0;
        }

        static string GetDayName(int num)
        {
            string[] dayNames = {
                "Senin",
                "Selasa",
                "Rabu",
                "Kamis",
                "Jumat",
                "Sabtu",
                "Minggu"
            };
            return dayNames[num];
        }

        static void WhileLoopGuessingGame()
        {
            bool startGuess = true;
            int guessesRemaining = 5;
            while (startGuess)
            {
                int randomNumber = GetRandomNumber(1, 10);

                Console.Write("\nGuess a random number between 1 - 10 :");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == userInput)
                {
                    Console.WriteLine("Yes! you're right!");
                }
                else
                {
                    guessesRemaining--;
                    Console.WriteLine($"You're wrong! the answer is {randomNumber} ({guessesRemaining} guesses remaining)");
                }

                if (guessesRemaining != 0)
                {
                    continue;
                }

                Console.Write("\nYou're running out of guess!\n");
                Console.Write("Want to play again? (y,n)");
                char confirm = Convert.ToChar(Console.ReadLine());

                if (confirm == 'y')
                {
                    startGuess = true;
                    guessesRemaining = 5;
                }
                else
                {
                    startGuess = false;
                }
            }
        }

        static void ForLoop()
        {
            int[] numbers = { 7, 17, 19, 9, 4, 3, 26 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Current number is {numbers[i]}");
            }
        }

        static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max + 1);
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        static void DimensionalArray()
        {
            int[,] dimensions =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 2, 4 }
            };

            Console.WriteLine(dimensions[0, 2]);
        }

        static void TryCatch()
        {
            try
            {
                Console.Write("Input a number :");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input another number :");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{number} / {number2} is {number / number2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("The program is done"); }
        }
    }
}