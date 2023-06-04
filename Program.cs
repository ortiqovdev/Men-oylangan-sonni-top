using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int computerNumber = random.Next(1, 11);
        int guessCount = 0;

        while (true)
        {
            Console.Write("Iltimos, 1 va 10 orasidagi bir son kiriting: ");
            int userNumber;

            if (int.TryParse(Console.ReadLine(), out userNumber))
            {
                if (userNumber < 1 || userNumber > 10)
                {
                    Console.WriteLine("Xato! Son 1 va 10 orasida bo'lishi kerak.");
                    continue;
                }

                guessCount++;

                if (userNumber == computerNumber)
                {
                    Console.WriteLine($"Tabriklayman! To'g'ri topdingiz. Jami urinishlar soni: {guessCount}");
                    break;
                }
                else
                {
                    string message = userNumber < computerNumber ? "Bundan katta" : "Bundan kichik";
                    Console.WriteLine($"{message} sonni kiriting.");
                }
            }
            else
            {
                Console.WriteLine("Xato! Butun son kiriting.");
            }
        }

        Console.ReadLine();
    }
}