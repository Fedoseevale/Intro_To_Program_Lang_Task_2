// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string DayNumber (int num)
{
   if (num == 1) 
   {
      string result = ("это понедельник -> рабочий день");
      return result;
   }
   if (num == 2) 
   {
      string result = ("это вторник -> рабочий день");
      return result;
   }
   if (num == 3) 
   {
      string result = ("это среда -> рабочий день");
      return result;
   }
   if (num == 4) 
   {
      string result = ("это четверг -> рабочий день");
      return result;
   }
   if (num == 5) 
   {
      string result = ("это пятница -> рабочий день");
      return result;
   }
   if (num == 6) 
   {
      string result = ("это суббота -> выходной день");
      return result;
   }
   else
   {
      string result = ("это воскресенье -> выходной день");
      return result;
   }
}

int number = new Random().Next(1, 8);
Console.WriteLine($"Цифра, обозначающая день недели: {number}");
Console.WriteLine(DayNumber(number));