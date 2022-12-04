
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");

int a = Convert.ToInt32(Console.ReadLine());

int b=a/10;
int c=b%10;

Console.WriteLine("Вторая цифра  ");

Console.WriteLine(c);
