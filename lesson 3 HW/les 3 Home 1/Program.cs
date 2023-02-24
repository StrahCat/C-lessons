// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] coordinates = new int[6];
coordinates[0] = prompt("Введите кординаты точки X1: ");
coordinates[2] = prompt("Введите кординаты точки Y1: ");
coordinates[4] = prompt("Введите кординаты точки Z1: ");
coordinates[1] = prompt("Введите кординаты точки X2: ");
coordinates[3] = prompt("Введите кординаты точки Y2: ");
coordinates[5] = prompt("Введите кординаты точки Z2: ");

double result =
Math.Sqrt(Math.Pow(coordinates[1] - coordinates[0], 2) +
Math.Pow(coordinates[3] - coordinates[2], 2) +
Math.Pow(coordinates[5] - coordinates[4], 2));

Console.WriteLine($"Расстояние между точками в 3Д пространстве:({Math.Round(result, 2)})");