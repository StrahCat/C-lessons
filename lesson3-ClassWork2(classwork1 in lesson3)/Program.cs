// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int doteXone = prompt("Введите кординаты первой точки X: ");
int doteXtwo = prompt("Введите кординаты второй точки X: ");
int doteYone = prompt("Введите кординаты первой точки Y: ");
int doteYtwo = prompt("Введите кординаты второй точки Y: ");

double resultX = Math.Pow(doteXtwo - doteXone, 2);
double resultY = Math.Pow(doteYtwo - doteYone, 2);
double distance = Math.Sqrt(resultX + resultY);

Console.WriteLine($"Расстояние между точками в 2Д пространстве:({distance})");