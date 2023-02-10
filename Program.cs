Console.Write("Input a First Number, ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Second Number, ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 0;
result = a / b;
if (b == result)
{
    Console.WriteLine("This is a square");
}
else
{
    Console.WriteLine("This is not square");
}