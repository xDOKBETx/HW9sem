﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29
*/


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
return FunctionAkkerman(m, n);
}

Console.WriteLine($"A({m},{n}) = {FunctionAkkerman(m, n)}");
