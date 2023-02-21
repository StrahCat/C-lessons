// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число и я покажу вам его третью цифру: ");
int InputNum = Convert.ToInt32(Console.ReadLine());

if (InputNum < 1000 && 100 <= InputNum)
{
    int result = InputNum % 10;
    Console.WriteLine($"{result}");
}
if (InputNum >= 1000 && 10000 >= InputNum)
{
    int result = (InputNum % 100) / 10;
    Console.WriteLine($"{result}");
}
if (InputNum > 10000 && 100000 >= InputNum)
{
    int result = (InputNum % 1000) / 100;
    Console.WriteLine($"{result}");
}
if (InputNum < 100 || 100000 < InputNum)
{
    Console.WriteLine($"Ваше число не имеет третьей цифры, либо больше 100тыс");
}
