// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
if (InputNum < 1000 && InputNum > 99)
{
    int a = InputNum % 100;
    int b = a / 10;
    Console.WriteLine($"Вторая цифра вашего числа {b}");
}
else
{
    Console.WriteLine($"Ваше число {InputNum} не трехзначное");
}