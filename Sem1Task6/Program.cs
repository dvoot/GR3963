// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

using System; // подключаем библиотеку классов
using static System.Console; // чтобы не обращаться каждый раз к классу Console 
WriteLine("Введите число: ");
int num = Convert.ToInt32(ReadLine()); //вводим и сразу конвертируем в integer т.к. ReadLine по умолчанию выдает string
if (num%2 == 0) WriteLine ($"Число {num} четное");
else WriteLine ($"Число {num} нечетное");