// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//Console.Write("Введите любое число от 1 до 7: ");
int number = new Random().Next(1, 8);
Console.WriteLine($"Цифра, обозначающая день недели: {number}");
//int number = Convert.ToInt32(Console.ReadLine());

// int Number (int num)
// {
if (number == 1)  Console.Write ("это понедельник -> рабочий день");
if (number == 2)  Console.Write ("это вторник -> рабочий день");
if (number == 3)  Console.Write ("это среда -> рабочий день");
if (number == 4)  Console.Write ("это четверг -> рабочий день");
if (number == 5)  Console.Write ("это пятница -> рабочий день");
if (number == 6)  Console.Write ("это суббота -> выходной день");
if (number == 7)  Console.Write ("это воскресенье -> выходной день");
   //{
        // return Convert.ToString ("-> рабочий день");
       
 //  }   
// }
// Console.Write(Number);