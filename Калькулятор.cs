using System.Globalization;
int nom1, nom2, result;
string num1, num2;
double result1, nam1;
string c = "0";
Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
while (c != "9") {

    Console.WriteLine("Выберите какую операцию выполнить: ");
    c = Console.ReadLine();

    if (c == "1") {
        Console.WriteLine("Введите первое число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);


        Console.WriteLine("Введите второе число: ");
        num2 = Console.ReadLine();
        nom2 = Convert.ToInt32(num2);

        Console.WriteLine("Результат: " + (nom1 + nom2));

    }
    else if (c == "2") {

        Console.WriteLine("Введите первое число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);


        Console.WriteLine("Введите второе число: ");
        num2 = Console.ReadLine();
        nom2 = Convert.ToInt32(num2);

        Console.WriteLine("Результат: " + (nom1 - nom2));
    }
    else if (c == "3")
    {
        Console.WriteLine("Введите первое число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);


        Console.WriteLine("Введите второе число: ");
        num2 = Console.ReadLine();
        nom2 = Convert.ToInt32(num2);

        Console.WriteLine("Результат: " + (nom1 * nom2));
    }
    else if (c == "4")
    {
        Console.WriteLine("Введите первое число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);


        Console.WriteLine("Введите второе число: ");
        num2 = Console.ReadLine();
        nom2 = Convert.ToInt32(num2);

        Console.WriteLine("Результат: " + (nom1 / nom2));
    }
    else if (c == "5")
    {
        Console.WriteLine("Введите число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);


        Console.WriteLine("Введите степень: ");
        num2 = Console.ReadLine();
        nom2 = Convert.ToInt32(num2);

        result = 1;

        for (int i = 1; i <= nom2; i++)
        {
            result = result * nom1;
        }
        Console.WriteLine("Резульат" + result);
    }
    else if (c == "6") {

        Console.WriteLine("Введите число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);
        result1 = Math.Sqrt(nom1);

        Console.WriteLine("Резульnат: " + result1);
    }
    else if (c == "7") {

        Console.WriteLine("Введите число: ");
        num1 = Console.ReadLine();
        nam1 = Convert.ToDouble(num1);
        result1 = nam1 / 100;
        Console.WriteLine("Резульnат: " + result1);
    }
    else if (c == "8") {

        Console.WriteLine("Введите число: ");
        num1 = Console.ReadLine();
        nom1 = Convert.ToInt32(num1);
        result = 1;
        for (int i = 1; i <=nom1 ; i++)
        {
            result *= i;
        }

        Console.WriteLine("Резульnат: " + result);
    }
}
