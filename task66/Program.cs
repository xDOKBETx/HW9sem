/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetsumMNNaturalElements(int M, int N)
{
    if(M == N) return M;
    else
    {
        if(M > N)
        {
            int temp = N;
            N = M;
            M = temp;
        }
    }

    return  M + GetsumMNNaturalElements(M + 1, N);
}

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int sumMN = GetsumMNNaturalElements(M, N);
Console.Write($"Сумма элементов интервала от {M} до {N} равна: {sumMN}");

