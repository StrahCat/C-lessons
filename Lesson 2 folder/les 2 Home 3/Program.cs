// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели от 1-7, и я подскажу выходной это или нет: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if (dayNum > 7 || 0 >= dayNum)
{
    Console.WriteLine("Нужно ввести цифру от 1 до 7, попробуй еще раз");
}
else
{
    switch (dayNum)
    {
        case 1:
            Console.WriteLine($"Цифра {dayNum} это Понедельник, не выходной");
            break;
        case 2:
            Console.WriteLine($"Цифра {dayNum} это Вторник, не выходной");
            break;
        case 3:
            Console.WriteLine($"Цифра {dayNum} это Среда, не выходной");
            break;
        case 4:
            Console.WriteLine($"Цифра {dayNum} это Четверг, не выходной");
            break;
        case 5:
            Console.WriteLine($"Цифра {dayNum} это Пятница, не выходной");
            break;
        case 6:
            Console.WriteLine($"Цифра {dayNum} это Суббота, выходной");
            break;
        case 7:
            Console.WriteLine($"Цифра {dayNum} это Воскресенье, выходной");
            break;
    }
}
