// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите  трёхначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------------------");
int secondNumber = (number % 100) / 10;
Console.WriteLine("Вторая цифра: " +secondNumber);

// либо можно что бы програама сама выводила это число 
// int number = new Random().Next(100, 999)
// Console.WriteLine("Трёхзначное число = " +number);