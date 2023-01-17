// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

Console.WriteLine("Введите число А:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
int y = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow (x, y);
Console.WriteLine(result);

