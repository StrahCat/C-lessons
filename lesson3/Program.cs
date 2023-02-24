// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int[] points = new int[2];
// for (int i = 0; i < points.Length; i++)
// {
//     while (true)
//     {
//         points[i] = Convert.ToInt32(Console.ReadLine());
//         if (points[i] != 0)
//             break;
//         else
//         {
//             Console.WriteLine("Incorrect input");
//         }
//     }
// }

// if (points[0] > 0 && points[1] > 0)
//     Console.WriteLine("1");
// else if (points[0] > 0 && points[1] < 0)
//     Console.WriteLine("2");
// else if (points[0] < 0 && points[1] < 0)
//     Console.WriteLine("3");
// else
//     Console.WriteLine("4");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int data = prompt("Введите число от 1 до 4: ");

switch (data)
{
    case 1:
        Console.WriteLine("Диапазон X");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        Console.WriteLine("Диапозон Y");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{i}, ");
        }
        break;
    case 2:
        Console.WriteLine("Диапазон X");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{i}, ");

        }
        Console.WriteLine();
        Console.WriteLine("Диапозон Y");
        for (int i = 0; i >= -10; i--)
        {
            Console.Write($"{i}, ");
        }
        break;
    case 3:
        Console.WriteLine("Диапазон X");
        for (int i = 0; i >= -10; i--)
        {
            Console.Write($"{i}, ");

        }
        Console.WriteLine();
        Console.WriteLine("Диапозон Y");
        for (int i = 0; i >= -10; i--)
        {
            Console.Write($"{i}, ");
        }
        break;
    case 4:
        Console.WriteLine("Диапазон X");
        for (int i = 0; i >= -10; i--)
        {
            Console.Write($"{i}, ");

        }
        Console.WriteLine();
        Console.WriteLine("Диапазон Y");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{i}, ");
        }
        break;
}
