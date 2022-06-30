// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите  трёхначное число");
string number = 1337.ToString(Console.ReadLine());
Console.WriteLine("------------------------------");
Console.WriteLine(number[2]);


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
