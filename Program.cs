// See https://aka.ms/new-console-template for more information

namespace Simple
{
    class Simple
    {
        public string name = "John Doe";

        static int Main(string[] args)
        {
            //WhileLoopGuessingGame();
            //ForLoop();
            //Console.WriteLine(GetPow(10, 7));
            DimensionalArray();
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

            Console.WriteLine(dimensions[0,2]);
        }

        static void 
    }
}