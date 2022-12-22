// Задача 4: Задайте двумерный массив. Введите элемент, 
// и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет.
// int number = Prompt("Enter a number ");
// int[,] matrix = new int[2, 2];
// PrintMatrix(number, matrix);
// Console.WriteLine(FindElement(number, matrix));
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
if (FindElement == null)
{
    Console.WriteLine("Not Founded");
}
else
{
    Console.WriteLine(FindElement(number, matrix));
}