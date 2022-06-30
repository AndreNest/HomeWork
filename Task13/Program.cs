// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.WriteLine("Введите  трёхначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("------------------------------");
// //string number = 1337.ToString(Console.ReadLine());
// //Console.WriteLine(number[2]);
// int index = 0;
// int count = number;
// while(count < 1)
// {
//     int count / 10;
// }




// if(number > 99 && number < 1000)
// {
//     int thirdNumber = (number % 100) % 10;
//     Console.WriteLine("Третья цифра = " +thirdNumber);
    
// }
// if(number > 999 && number < 10000)
// {
//     int thirdNumber2 = (number % 1000) % 100 / 10;
//     Console.WriteLine("Третья цифра = " +thirdNumber2);
// }
// else
// {
//     Console.WriteLine("В числе нет третьей цифры");;
// }
void thirdNumber(int x)
{
    int div = 1;
    while(x / div >= 10)
    {
        div *= 10;
    }
    if(div < 100)
    {
        Console.WriteLine("Цифры три нет!");
    }
    else
    {
        int digit = (x / (div/100)) % 10;
        Console.WriteLine("Треть цифра = {0} ", + digit);
    }
}


thirdNumber(1234567);
thirdNumber(118111111);
thirdNumber(881);
