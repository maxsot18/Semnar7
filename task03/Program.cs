// Решение в группах задач:
// Задача 2: Задайте двумерный массив. 
// Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
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

int[,] Array(int[,] array, int m, int n)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (i + 1) * (j + 1);
        }
    }
    return array;
}

int m = Prompt("Enter a quantity of strings ");
int n = Prompt("Enter a quantity of pillars ");
int[,] arr = new int[m, n];
PrintMatrix(Array(arr, m, n));


