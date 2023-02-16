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

## WORK WITH ARRAY

* **int[] array**