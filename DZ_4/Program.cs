// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Четные числа от 1 до N. Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num = n-n+2;
while (num <= n)
{
    Console.Write($" {num} ");
    num++;
    if ((num % 2)==0);
}
Console.WriteLine($" <- {num}");