// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum % secondNum == 0)
{
    Console.Write("Первое число является квадратом второго");
}
else if (secondNum % firstNum == 0)
{
    Console.WriteLine("Второе число является квадратам первого");
}
else
{
    Console.WriteLine("Оба числа не являются квадратами друг друга");
}