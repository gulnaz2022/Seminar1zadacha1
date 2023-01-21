// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] creatArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int pozSum(int[] array)
{
int count = 0;
foreach (int a in array){
    if (a > 0) count++;
}return count;
}    
int m = new Random().Next(1, 10);
Console.WriteLine($"Ввепдите {m} положительных ит отрицательных чисел");
int[] numbers = new int[m];
Console.WriteLine(creatArray(numbers));
Console.WriteLine($"В массиве {pozSum(numbers)} положительных чисел");

