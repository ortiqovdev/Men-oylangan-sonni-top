using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Darajali oyin. Levelni tanlang:");
        Console.WriteLine("1. 1 - 10 oraliq");
        Console.WriteLine("2. 1 - 100 oraliq");
        Console.WriteLine("3. 1 - 1000 oraliq");
        Console.Write("Tanlovni kiriting (1, 2 yoki 3): ");

        int level;
        if (!int.TryParse(Console.ReadLine(), out level)  level < 1  level > 3)
        {
            Console.WriteLine("Noto'g'ri tanlov! Dasturni qayta ishga tushuring.");
            Console.ReadLine();
            return;
        }

        int maxNumber = 0;
        switch (level)
        {
            case 1:
                maxNumber = 10;
                break;
            case 2:
                maxNumber = 100;
                break;
            case 3:
                maxNumber = 1000;
                break;
        }

        Random random = new Random();
        int computerNumber = random.Next(1, maxNumber + 1);
        int guessCount = 0;

        while (true)
        {
            Console.Write($"Iltimos, 1 va {maxNumber} orasidagi bir son kiriting: ");
            int userNumber;

            if (int.TryParse(Console.ReadLine(), out userNumber))
            {
                if (userNumber < 1 || userNumber > maxNumber)
                {
                    Console.WriteLine($"Xato! Son 1 va {maxNumber} orasida bo'lishi kerak.");
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
