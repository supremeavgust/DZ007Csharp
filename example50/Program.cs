// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"[{matrix[i, j]}]   ");
        Console.WriteLine();
    }

}
void ArrayRandom(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}
Console.Clear();
int i = new Random().Next(2, 5);
int j = new Random().Next(2, 5);
int[,] matrix = new int[i, j];

ArrayRandom(matrix);
Print(matrix);
Console.Write("Введите позицию строки: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
    if (k < 1 || b < 1)
    Console.Write("Позиции строк не могут быть отрицательными");
    else if (k == i + 1 && b == j + 1)
    Console.Write($"Значение элемента равно {matrix[k - 1, b - 1]}");
    else Console.Write("Такого элемента нет в массиве");