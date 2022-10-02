//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Решение без использовния метода

//Решение позволяет работать как с положительными числами, так и с отрицательными

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 10) > -10 && (number / 10) < 10)
{
    Console.WriteLine("У данного числа третьей цифры нет");
}
else if (((number / 10) > 0 && (number / 10) < 100) || ((number / 10) < 0 && (number / 10) > - 100))
{
    int thirdNumber = Math.Abs (number % 10);
    Console.WriteLine($"Третья цифра данного числа: {thirdNumber}");
}
else
{
    while ((number > 999) || (number <-999))
    {
        number = Math.Abs(number / 10);
    }
    Console.WriteLine($"Третья цифра данного числа: {number % 10}");
}

