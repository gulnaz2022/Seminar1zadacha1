//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[]numbers = new int[size];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-100,100);
    Console.Write( $"{numbers[i]} ");
}
Console.Write("]");
Console.WriteLine("<- Массив чисел");
int sum = 0;
for (int j = 0; j < numbers.Length; j++)
{
   sum = sum + numbers[j]; 
}
Console.WriteLine( $"Сумма элеентов на нечетных позициях: {sum}" );