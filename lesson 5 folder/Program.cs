Console.Clear();
Prompt("1 - Задача номер 1");
Prompt("2 - Задача 2");
Prompt("3 - Задача 3");
Prompt("4 - Задача 4");
int tasks = PromptInput("Введите номер задачи: ");
static void Prompt(string message)
{
    Console.WriteLine(message);
}
static int PromptInput(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;

}
switch (tasks)
{
    case 1:
        // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
        // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
        Task_01();
        break;
    case 2:
        Task_02();
        break;
    case 3:
        Task_03();
        break;
    case 4:
        Task_04();
        break;
    case 5:
        Task_05();
        break;
}

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
static void Task_01()
{
    int[] result = new int[12];
    int pos = 0;
    int neg = 0;

    static int[] GetArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-9, 10);
        }
        return array;
    }


    void SumArray(int[] array)
    {
        foreach (int i in array)
        {
            if (i > 0)
            {
                pos += i;
            }
            else
            {
                neg += i;
            }
        }
    }

    void PrintResult(int[] array, int pos, int neg)
    {
        Console.WriteLine($"Here is Array {string.Join(",", array)}");
        Console.WriteLine($"Here is sum of Positive: {pos}, Sum of Negative: {neg}");
    }

    SumArray(GetArray(result));
    PrintResult(result, pos, neg);
}

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
static void Task_02()
{
    int[] array = new int[10];

    static int[] GetArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 10);
        }
        return array;
    }

    static int[] ChangeSymb(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= -1;
        }
        return array;
    }


    ChangeSymb(GetArray(array));
    Console.WriteLine($"Here is our Array: {string.Join(",", array)} and Here is our Reverse: {string.Join(",", ChangeSymb(array))}");

}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да
static void Task_03()
{
    int[] array = new int[] { 6, 7, 19, 345, 3 };
    int num = PromptInput($"Введите число посмотрим есть ли он в массиве: ");

    static bool FindNum(int[] array, int num, out int i) // out int в данном случае объявляет динамическую переменую куда мы запишем значение i на момент получения True;
    {
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
                return true;
        }
        return false;
    }

    if (FindNum(array, num, out int i))
        Console.WriteLine($"{num}; массив {string.Join(",", array)} -> да, индекс числа {i}");
    else
        Console.WriteLine($"{num}; массив {string.Join(",", array)} -> нет");
}

static void Task_04()
{
    int[] array = new int[123];
    Random rand = new Random();
    int sum = 0;

    int[] GetArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 200);
        }
        return array;
    }

    int FindNumb(int[] array, int sum)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 10 && 99 >= array[i])
                sum++;
        }
        return sum;
    }
    Console.WriteLine($"Our Array: {string.Join(",", GetArray(array))}");
    Console.WriteLine($"Our sum of number from 10 to 99: {FindNumb(array, sum)}");
}

static void Task_05()
{

    int[] array = new int[] { 1, 2, 3, 4, 5 };
    int[] result;

    if (array.Length % 2 != 0) //проверяем четность и нечетность массива
    {
        result = new int[array.Length / 2 + 1]; // Увеличиваем длинну массива на 1
        result[array.Length / 2] = array[array.Length / 2];  // подставляем 3 число массива в массив с результатом
    }
    else
    {
        result = new int[array.Length / 2];
    }

    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        result[i] = array[i] * array[j];
    }

    Console.WriteLine($"Our array {string.Join(" ", array)}, and here is our result {string.Join(" ", result)}");
}

