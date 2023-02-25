// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int promptInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void prompt(string message)
{
    System.Console.WriteLine(message);
}

void numSq(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int result = i * i;
        Console.Write($"{result} ");
    }
}

int userNum = promptInput("Напишите число но не слишком длинное: ");
prompt($"Список квдратов чисел от 1 до {userNum}:");
numSq(userNum);
