// Задача 3: Задайте двумерный массив. 
// Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12






void PrintMatrix(int m, int [,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }


}

int Prompt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}



int SumDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + arr[i, j];
            }
            else
        {
            continue;
        }
        }
        

    }
    return sum;
}
int m = Prompt("Enter a quantity of strings and pillars ");

int [,] array = new int[m , m];;
PrintMatrix(m, array);

Console.Write($"Sum of diagonal= {SumDiagonal(array)}");








