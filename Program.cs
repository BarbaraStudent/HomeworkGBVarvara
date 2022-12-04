
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Console.WriteLine("Введите трёхзначное число");
//int a = Convert.ToInt32(Console.ReadLine());
//int b=a/10;
//int c=b%10;
//Console.WriteLine("Вторая цифра  ");
//Console.WriteLine(c);

//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

//Console.WriteLine("Введите число");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = a % 100;
//int c = b % 10;
//if (a >= 100)
//{
//  Console.WriteLine("третья цифра -> " + c);
//}
//else {
//  Console.WriteLine("-> третьей цифры нет");
//}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введи цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

  if (a == 6 || a == 7) {
  Console.WriteLine("Выходной");
  }
  else if (a < 1 || a > 7) {
    Console.WriteLine("Ошибка");
  }
  else Console.WriteLine("Рабочий");

