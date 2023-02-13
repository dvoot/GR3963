// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using System; // подключаем библиотеку классов
using static System.Console; // чтобы не обращаться каждый раз к классу Console 
WriteLine("Введите первое число: ");
int numOne = Convert.ToInt32(ReadLine()); //вводим и сразу конвертируем в integer т.к. ReadLine по умолчанию выдает string
WriteLine("Введите второе число: ");
int numTwo = Convert.ToInt32(ReadLine());
if (numOne == numTwo) {WriteLine("Введенные числа равны");
return;}
if (numOne > numTwo) WriteLine($"Число {numOne} больше {numTwo}");
else WriteLine($"Число {numTwo} больше {numOne}");
