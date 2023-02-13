// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System; // подключаем библиотеку классов
using static System.Console; // чтобы не обращаться каждый раз к классу Console 
WriteLine("Введите число: ");
int num = Convert.ToInt32(ReadLine());
int evenNum = 2;
while (evenNum <= num)
{
    Write($"{evenNum}  ");
    evenNum = evenNum + 2;
}