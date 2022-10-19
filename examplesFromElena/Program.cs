using System;
using System.Linq;
using System.Text;

Console.Clear();

// // Задача 1

// int n = new Random().Next(20, 100);
// Console.WriteLine("Случайное число " + n);
// Console.WriteLine("Введите целое число: ");
// int d = Convert.ToInt32(Console.ReadLine());
// string result;

// result = (n % d == 0) ? "делится на " : "не делится на ";
// Console.Write("{0} {1} {2}",n,result,d);

// // Задача 2

// int a = new Random().Next(10, 30);
// Console.WriteLine("First number: " + a);

// int b = new Random().Next(10, 30);
// Console.WriteLine("Second number: " + b);

// if (a < b)
// {
//     Console.Write(a + b);
// }
// else if (a > b)
// {
//     Console.Write(a - b);
// }
// else
// {
//     Console.Write("This numbers is equal");
// }

// // Задача 3

int c = new Random().Next(-10, 10);
Console.WriteLine("First number: " + c);

int d = new Random().Next(-10, 10);
Console.WriteLine("Second number: " + d);

if (c % 2 == 0 && d % 2 == 0)
{
    Console.Write(c / d);
}
else if (c % 2 == 1 && d % 2 == 1)
{
    Console.Write(c + d);
}
else 
{
    Console.Write(c * d);
}