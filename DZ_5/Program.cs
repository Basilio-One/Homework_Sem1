﻿// Задача 7 HARD: - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div1 = num % 100;
int div2 = div1 /10;
    
if (num>1000 && num<9999) 
{
    Console.WriteLine($"Третяя цифра: {div2} ");
}
else
{
    Console.WriteLine($" Нет ответа");
}