// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            matr[i, j] = new Random().Next(-100, 100);
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

int strings = Prompt("Enter a quantity of strings ");
int pillows = Prompt("Enter a quantity of pillows ");
int [,] matr = new int [strings, pillows];
PrintMatrix(matr);

