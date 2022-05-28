/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int[,] array = new int[1000,1000];
double[] avg = new double[1000];
int i = 0, j = 0, cap = 0, k = 0;
Random rand = new Random();

Console.Clear();
Console.WriteLine("Введите размерность массива MxN с клавиатуры через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0]; j++)
        array[i,j] = rand.Next(100);

Console.Clear();
Console.WriteLine("Сгенерированный массив: " + size[0] + "x" + size[1]);

for (i = 0; i < size[1]; i++) {
    for (j = 0; j < size[0]; j++)
        if (array[i,j] < 10) Console.Write(" " + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");
    Console.WriteLine();
}

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0] ; j++)
        for (k = 0; k < size[0]; k++) {
            if (array[i,j] > array[i,k]) {
                cap = array[i,k];
                array[i,k] = array[i,j];
                array[i,j] = cap;
            }
        }

Console.WriteLine("Отсортированный массив: " + size[0] + "x" + size[1]);

for (i = 0; i < size[1]; i++) {
    for (j = 0; j < size[0]; j++)
        if (array[i,j] < 10) Console.Write(" " + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");
    Console.WriteLine();
}
