// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите  трёхначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------");
if(number < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    int thirdNumber = (number % 100) % 10;
Console.WriteLine("Третье цифра = " +thirdNumber);
}
