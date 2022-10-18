


// // Задача 10 На входе трехзначное число, на выходе вторая цифра этого числа (рещение 1)
// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// string num = Convert.ToString(Console.ReadLine());

// Console.Write(num[1]);

// // Задача 10 На входе трехзначное число, на выходе вторая цифра этого числа (рещение 2)

// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (100 <= num  && num < 1000)
// {
//     Console.Write((num / 10) % 10); 
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }    

// Задача 13 Вывод третьей цифры заданного числа

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000)
{
    Console.Write(num % 10);
}
else if (num < 100)
{
    Console.Write("Третьей цифры в данном числе нет");
}
else 
{
    Console.Write("Число больше трехзначного");
}
