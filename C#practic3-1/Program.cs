// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да

Console.WriteLine("Введите 5-значное число:");
int num = Convert.ToInt32(Console.ReadLine());
int poz1 = num/10000;
int poz2 = (num/1000)%10;
int poz4 = (num/10)%10;
int poz5 = num%10;
if (poz1==poz5&&poz2==poz4)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не полиндром");
}