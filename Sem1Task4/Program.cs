// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System; // подключаем библиотеку классов
using static System.Console; // чтобы не обращаться каждый раз к классу Console 
int i = 1;
int maxNum = 0;
while (i <= 3)
{
    WriteLine($"Введите число № {i}");
    int num = Convert.ToInt32(ReadLine());
    if (i == 1) maxNum = num;
    else if (num > maxNum) maxNum = num;
    i++;
}
WriteLine($"Максимальное число = {maxNum}");

