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

string example = Console.ReadLine();

int a = Convert.ToInt32(example);


_**For text always use "".**_
_**If you want to use numbers from string variable, always convert data in to numbers like "Convert.ToInt32();"**_



## First Algorithm

* Console.Write("Input an Number, ");
* string example = Console.ReadLine();
* int a = Convert.ToInt32(example);
* int result = 0;
* Console.Write("result, ");
* result = a * a;
* Console.WriteLine(result);

## Second Algo (Is a square of b ?)

* Console.Write("Input a First Number, ");
* int a = Convert.ToInt32(Console.ReadLine());
* Console.Write("Input a Second Number, ");
* int b = Convert.ToInt32(Console.ReadLine());
* int result = 0;
* result = a / b;
* if (b == result)
{
    Console.WriteLine("This is a square");
}
* else
{
    Console.WriteLine("This is not square");
}

## Third Algo (Input number, which day of the week this number ?)

* **switch ("variable")** - create a many different options for what variable means or make. (look third algo)
* **case** - init variable for numbers (case 1;) for text variable (case "Monday";)
* **break** - always in the end to break the algo and give as a right answer from "switch".

* Console.Write("Input a day number, ");
* int a = Convert.ToInt32(Console.ReadLine());
* switch (a)
* {
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

## Algo 5 (Numbers from -)

* Console.WriteLine("Input Number, ");
* int a = Convert.ToInt32(Console.ReadLine());

* for (int i = -a; i <= a; i++)
{
    Console.WriteLine(i);
}