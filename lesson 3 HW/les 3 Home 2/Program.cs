// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int promptInput(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool fifthSymbCheck(int number)
{
    if (number > 99999)
    {
        Console.WriteLine($"{number} не являеется 5 значным");
        return false;
    }
    return true;
}

bool Polyndrome(int number)
{
    int firstTwo = number / 1000;
    int lastTwo = number % 100;
    int check = ((lastTwo % 10) * 10) + lastTwo / 10;
    if (check == firstTwo)
    {
        return true;
    }
    else
    {
        return false;
    }

}

int fifthnumber = promptInput("Введите 5ти значное число на проверку Полиндромом: ");
if (fifthSymbCheck(fifthnumber))
{
    if (Polyndrome(fifthnumber))
        Console.WriteLine($"Число является полиндромом");
    else
        Console.WriteLine($"Число не является полиндромом");
}