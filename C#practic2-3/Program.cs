// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Является ли выходным день недели под цифрой:");
int num = Convert.ToInt32(Console.ReadLine());
if (num==7||num==6)
{
   Console.WriteLine("Да"); 
}
else if (num>=1&&num<6)
{
    Console.WriteLine("Нет");

}
else
{
    Console.WriteLine("Ведите цифру от 1 до 7");
}