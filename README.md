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

## Second Algo 

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