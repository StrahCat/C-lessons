# C-lessons

* **dotnet new console** - init C# in repo
* **dotnet run** - run programm in Terminal



## Syntax
* **string** - initiate string variable
* **int** - initiate number variable

## Console syntax
* **Console.WriteLine("some text")** - Write data, analog (print) and (Console.Log)
* **Console.ReadLine()** - Input some data analog (input)
* **Console.ToInt32** - converting getting data as a numbers of 32bit's 

for Example:

string example = Console.ReadLine();<br>
int a = Convert.ToInt32(example);<br>


_**For text always use "".**_
_**If you want to use numbers from string variable, always convert data in to numbers like "Convert.ToInt32();"**_



## First Algorithm

Console.Write("Input an Number, ");<br>
string example = Console.ReadLine();<br>
int a = Convert.ToInt32(example);<br>
int result = 0;<br>
Console.Write("result, ");<br>
result = a * a;<br>
Console.WriteLine(result);<br>

## Second Algo (Is a square of b ?)

Console.Write("Input a First Number, ");<br>
int a = Convert.ToInt32(Console.ReadLine());<br>
Console.Write("Input a Second Number, ");<br>
int b = Convert.ToInt32(Console.ReadLine());<br>
int result = 0;<br>
result = a / b;<br>
if (b == result)<br>
{<br>
    Console.WriteLine("This is a square");<br>
}<br>
else<br>
{<br>
    Console.WriteLine("This is not square");<br>
}<br>

## Third Algo (Input number, which day of the week this number ?)

* **switch ("variable")** - create a many different options for what variable means or make. (look third algo)
* **case** - init variable for numbers (case 1;) for text variable (case "Monday";)
* **break** - always in the end to break the algo and give as a right answer from "switch".

Console.Write("Input a day number, ");<br>
int a = Convert.ToInt32(Console.ReadLine());<br>
switch (a)<br>
{<br>
    case 1:<br>
        Console.WriteLine("Monday");<br>
        break;<br>
    case 2:<br>
        Console.WriteLine("Tuesday");<br>
        break;<br>
    case 3:<br>
        Console.WriteLine("Wednesday");<br>
        break;<br>
    case 4:<br>
        Console.WriteLine("Thursday");<br>
        break;<br>
    case 5:<br>
        Console.WriteLine("Friday");<br>
        break;<br>
    case 6:<br>
        Console.WriteLine("Saturday");<br>
        break;<br>
    case 7:<br>
        Console.WriteLine("Sunday");<br>
        break;<br>
}<br>

## Algo 5 (Numbers from -)

* **Math.Abs** - create any number positive, for example if there is -3 it convert it in 3.

Console.WriteLine("Input Number, ");<br>
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));<br>
for (int i = -a; i <= a; i++)<br>
{<br>
    Console.WriteLine(i);<br>
}

## Algo 6 (Show us last number of number with at least 3 characters 768 = 8, 243 = 3 e.t.c)

Console.WriteLine("Input number with 3 characters, ");<br>
int a = Convert.ToInt32(Console.ReadLine());<br>
if (a / 100 == 0 || a / 100 > 9)<br>
{<br>
    Console.WriteLine("This number is not correct");<br>
}<br>
else<br>
{<br>
    int result = a % 10;<br>
    Console.WriteLine($"Your last number of {a}, is {result}");<br>
}<br>

## Algo 7

// random number from 10 to 99<br>
// show me last number of that number 78 = 8, 99 = 9<br>
// [10,99] - 10 и 99 включены в диапазон;<br>
// (10, 99) - 10 и 99 невключены в диапазон; <br>
// Console.WriteLine("text example" + " " + a); - how to print text + variable<br>
// Console.WriteLine("Text {0} example {1} and one more {2}", + a, b, c); - how to print text + variable<br>
// Console.WriteLine($"text {a} and here more variable {b}"); - how to print text + variable<br>

Random createNumber = new Random(); // create random number;<br>
int number = createNumber.Next(10, 99); //method "Next" choose number<br> include 10 but exclude 99;<br>
int a = number / 10;<br>
int b = number % 10;<br>

if (a > b)<br>
{<br>
    Console.WriteLine("Первая цифра больше второй");<br>
}<br>
else if (a < b)<br>
{<br>
    Console.WriteLine("Вторая цифра больше первой");<br>
}<br>
else<br>
{<br>
    Console.WriteLine("Цифры равны");<br>
}<br>

## Algo 8

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.<br>

// 456 -> 46<br>
// 782 -> 72<br>
// 918 -> 98<br>

Random createNum = new Random();<br>
int random = createNum.Next(100, 999);<br>

int a = random % 10;<br>
int b = random / 100;<br>
Console.WriteLine(random);<br>
Console.WriteLine($"Наше число {b}{a}");<br>

## Algo 9

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.<br>

// 5, 25 -> да<br>
// -4, 16 -> да<br>
// 25, 5 -> да<br>
// 8,9 -> нет<br>
Console.WriteLine("Введите первое число: ");<br>
int firstNum = Convert.ToInt32(Console.ReadLine());<br>
Console.WriteLine("Введите второе число: ");<br>
int secondNum = Convert.ToInt32(Console.ReadLine());<br>
if (firstNum % secondNum == 0)<br>
{<br>
    Console.Write("Первое число является квадратом второго");<br>
}<br>
else if (secondNum % firstNum == 0)<br>
{<br>
    Console.WriteLine("Второе число является квадратам первого");<br>
}<br>
else<br>
{<br>
    Console.WriteLine("Оба числа не являются квадратами друг друга");<br>
}<br>

## Algo 10
// Напишите программу, которая будет принимать на вход два числа и выводить,является ли первое число кратным второму.<br>
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.<br>
// 34, 5 -> не кратно, остаток 4<br>
// 16, 4 -> кратно<br>

Console.WriteLine("Введите двухзначное Число: ");<br>
int FirstNum = Convert.ToInt32(Console.ReadLine());<br>
Console.WriteLine("Введите однозначное Число: ");<br>
int SecondNum = Convert.ToInt32(Console.ReadLine());<br>

if (FirstNum % SecondNum == 0)<br>
    Console.WriteLine($"{FirstNum} кратно {SecondNum}");<br>
else<br>
{<br>
    int result = FirstNum % SecondNum;<br>
    Console.WriteLine($"{FirstNum} не кратно {SecondNum} остаток от деления {result}");<br>
}<br>

## Algo 11

// Напишите программу, которая принимает на вход число и проверяет,<br> 
// кратно ли оно одновременно<br>
// 7 и 23.<br>
// 14 -> нет<br>
// 46 -> нет<br>
// 161 -> да<br>
Console.WriteLine("Введите двухзначное Число: ");<br>
int FirstNum = Convert.ToInt32(Console.ReadLine());<br>

if (FirstNum % 7 == 0 && FirstNum % 23 == 0)<br>
    Console.WriteLine("True");<br>
else<br>
{<br>
    Console.WriteLine("False");<br>
}<br>

## Algo 12

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),<br>
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.<br>

int[] points = new int[2];<br>
for (int i = 0; i < points.Length; i++)<br>
{<br>
    while (true)<br>
    {<br>
        points[i] = Convert.ToInt32(Console.ReadLine());<br>
        if (points[i] != 0)<br>
            break;<br>
        else<br>
        {<br>
            Console.WriteLine("Incorrect input");<br>
        }<br>
    }<br>
}<br>

if (points[0] > 0 && points[1] > 0)<br>
    Console.WriteLine("1");<br>
else if (points[0] > 0 && points[1] < 0)<br>
    Console.WriteLine("2");<br>
else if (points[0] < 0 && points[1] < 0)<br>
    Console.WriteLine("3");<br>
else<br>
    Console.WriteLine("4");<br>


## Math Square and Root in c#

* **double resultX = Math.Pow(doteXtwo - doteXone, 2);** //Вот такой синтаксис Math.Pow(base, exponent)
* **double resultY = Math.Pow(doteYtwo - doteYone, 2);**
* **double distance = Math.Sqrt(resultX + resultY);** //Вот такой синтаксис Math.Sqrt(number)

## WORK WITH ARRAY

* **Random variableName = new Random();** - create randim number

* **int[] array** - Init array
       
* **int[] array1 = new int[5];** - Declare a single-dimensional array of 5 integers.

* **int[] array2 = new int[] { 1, 3, 5, 7, 9 };** -  Declare and set array element values.

* **int[] array3 = { 1, 2, 3, 4, 5, 6 };** - Alternative syntax.

* **Console.WriteLine($"{string.Join(",", array)}");** - print whole array without function **string.Join("separator", value);**

* **string str = string.Join(" ", array);** - create Method named "str" can use any name u like, so by using this we can print array by using **Console.WriteLine(str);**

## object.ToCharArray 

public static void Main()<br>
   {<br>
      string s = "AaBbCcDd";<br>
      char[] chars = s.ToCharArray(); // Здесь мы преоброзовали стринг S в массив chars<br>
      Console.WriteLine("Original string: {0}", s);<br>
      Console.WriteLine("Character array:");<br>
      for (int ctr = 0; ctr < chars.Length; ctr++)<br>
      {<br>
         Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);<br>
      }<br>
   }<br>
}<br>
