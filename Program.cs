// random number from 10 to 99
// show me last number of that number 78 = 8, 99 = 9
// [10,99] - 10 и 99 включены в диапазон;
// (10, 99) - 10 и 99 невключены в диапазон; 
// Console.WriteLine("text example" + " " + a); - how to print text + variable
// Console.WriteLine("Text {0} example {1} and one more {2}", + a, b, c); - how to print text + variable
// Console.WriteLine($"text {a} and here more variable {b}"); - how to print text + variable

Random createNumber = new Random(); // create random number;
int number = createNumber.Next(10, 99); //method "Next" choose number include 10 but exclude 99;
int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.WriteLine("Первая цифра больше второй");
}
else if (a < b)
{
    Console.WriteLine("Вторая цифра больше первой");
}
else
{
    Console.WriteLine("Цифры равны");
}
