// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }


}
void AverageOfEachColumns(int[,] matr)
{


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        double sum = 0;
        double average = 0;


        for (int j = 0; j < matr.GetLength(1); j++)
        {

            sum = matr[i, j] + sum;

            average = sum / matr.GetLength(1);



        }
        Console.WriteLine($"Average is of {i + 1} column {average}");
    }
}

int[,] matr = new int[5, 5];
PrintMatrix(matr);
AverageOfEachColumns(matr);