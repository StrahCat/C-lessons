// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Введите двухзначное Число: ");
int FirstNum = Convert.ToInt32(Console.ReadLine());

if (FirstNum % 7 == 0 && FirstNum % 23 == 0)
    Console.WriteLine("True");
else
{
    Console.WriteLine("False");
}
