//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int SecondNum(int num)
{
    int firstStep = num / 10;
    int secondNum = firstStep % 10;
    return secondNum;
}
//Вариант 1
Console.WriteLine("Введите любое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра этого числа: {SecondNum(number)}");

//Вариант 2
//int number = new Random().Next(100, 1000);
//Console.WriteLine($"Имеется трёхзначное число: {number}");
//Console.WriteLine($"Вторая цифра этого числа: {SecondNum(number)}");
