// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8
// % = деление с отстатком.
Console.WriteLine("Input number with 3 characters, ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 100 == 0 || a / 100 > 9)
{
    Console.WriteLine("This number is not correct");
}
else
{
    int result = a % 10;
    Console.WriteLine($"Your last number of {a}, is {result}");
}