// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num = prompt("Задайте число покажу квадраты чисел: ");

for (int i = 0; i <= num; i++)
{
    Console.Write($"{i * i}, ");
}