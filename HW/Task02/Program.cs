// Задача 2. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7

void PrintMatrix(int[,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 1; j < matr.GetLength(1); j++)
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

(int?, int?) FindElement(int value, int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (matr[i, j] == value)
            {

                return (i, j);

            }

        }
    }
    return (null, null);
}

int number = Prompt("Enter a number ");
int[,] matrix = new int[5, 5];
PrintMatrix(matrix);
(int? Col, int? Rows) = FindElement(number, matrix);
if (Col == null)
{
    Console.WriteLine("Don't have this number in matrix");
}
else
{
    Console.WriteLine($"Searching number is on {FindElement(number, matrix)}");
}
