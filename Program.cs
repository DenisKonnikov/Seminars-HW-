﻿
/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


/*Console.WriteLine ("Первое число:");
int number1=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Второе число:");
int number2=int.Parse(Console.ReadLine()!);
if(number1 > number2){
    Console.WriteLine($"Первое число {number1} больше второго {number2}");
}
else{
    Console.WriteLine($"Второе число {number2} больше первого {number1}");
}*/


/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


/*Console.WriteLine ("Первое число:");
int number1=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Второе число:");
int number2=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Третье число:");
int number3=int.Parse(Console.ReadLine()!);
int max = 0;
if (number1 > number2 && number1 > number3) max = number1;
if (number1 < number2 && number2 > number3) max = number2;
if (number3 > number1 && number2 < number3) max = number3;
Console.Write("max=");
Console.WriteLine (max);*/


/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
 if(number%2 == 0) {
    Console.WriteLine($"Число {number} является четным");
 }
else {
    Console.WriteLine($"Число {number} не четное");
}*/

/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/


/*Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int index = 1;

while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index}, ");
    }
    index = index + 1;
}*/
