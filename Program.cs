using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

int nom1, nom2,a;
string num1 ;
string c = "0";

while (c != "4")
{
    Console.WriteLine("1. Игра Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Выйти из программы");

    c = Console.ReadLine();

    if (c == "1")
    {
        Random rnd = new Random();
        nom1 = rnd.Next(0, 100);



        do
        {
            Console.Write("Введите число: ");
            num1 = Console.ReadLine();
            nom2 = Convert.ToInt32(num1);
            if (nom1 > nom2)
            {
                Console.WriteLine("Введите число больше");
            }
            else
            {
                Console.WriteLine("Введите число меньше");
            }

        } while (nom2 != nom1);
        Console.WriteLine("Вы выиграли!");
    }
    else if (c == "2")
    {
        int[,] table = new int[10, 10];
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                table[i, j] = i * j;
            }
        }
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    else if (c == "3")
    {
        Console.WriteLine("Введите число");
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                Console.WriteLine(i);
            }


        }
    }
}