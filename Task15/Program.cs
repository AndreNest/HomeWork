// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите  число от 1 до 7");

int days = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");
string[] weekDays = new String[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if(days == 6 || days == 7)
{
    Console.WriteLine(weekDays[days - 1] +" - это выходной!");
}
if(days > 0 && days < 6)
{
    Console.WriteLine(weekDays[days - 1] +" - это будний день!");
}
