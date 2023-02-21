// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите двухзначное Число: ");
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите однозначное Число: ");
int SecondNum = Convert.ToInt32(Console.ReadLine());

if (FirstNum % SecondNum == 0)
    Console.WriteLine($"{FirstNum} кратно {SecondNum}");
else
{
    int result = FirstNum % SecondNum;
    Console.WriteLine($"{FirstNum} не кратно {SecondNum} остаток от деления {result}");
}