Console.Clear();
prompt("1 - Кол-во цифр в числе + произведение чисел от 1 до введенного числа");
prompt("2 -Массив из 8 чисел заполненый 0 и 1");
int Tasks = Convert.ToInt32(PromptInput("Введите номер алгоритма"));
switch (Tasks)
{
    case 1:
        // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
        // 456 -> 3
        // 78 -> 2
        // 89126 -> 5
        // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
        // 4 -> 24
        // 5 -> 120
        Task_01_02();
        break;
    case 2:
        // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
        // [1,0,1,1,0,1,0,0]
        Task_03();
        break;
}

static int PromptInput(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

static void prompt(string message)
{
    Console.WriteLine(message);
}

static int NumLenght(char[] array)
{
    int result = 0;
    for (int i = 0; i <= array.Length; i++)
    {
        result = i;
    }
    return result;
}

static int NumCount(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

static void Task_01_02()
{
    int userNum = PromptInput("Введите число я покажу кол-во цифр в числе: ");
    char[]
        numLenght = userNum.ToString().ToCharArray();
    prompt($"Длинна числа, {NumLenght(numLenght)}, а произведение чисел от 1 до {userNum} равна {NumCount(userNum)}");
}

static void Task_03()
{
    Random rand = new Random();
    int[] array = new int[8];
    prompt($"вывожу массив из 8 чисел в Ряд:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    prompt($"{string.Join(",", array)}");
}

