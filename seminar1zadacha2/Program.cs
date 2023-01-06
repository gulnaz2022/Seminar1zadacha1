Console.Write("Введите первое число1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число2:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число3:");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("максимальное - ");
Console.Write(max);

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
