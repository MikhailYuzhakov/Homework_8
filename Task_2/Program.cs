/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] array = new int[1000,1000];
int[] sum = new int[1000];
int i = 0, j = 0, row_numb = 0, max = 0;
Random rand = new Random();

Console.Clear();
Console.WriteLine("Введите размерность массива MxN с клавиатуры через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0]; j++)
        array[i,j] = rand.Next(100);

Console.Clear();
Console.Clear();
Console.WriteLine("Сгенерированный массив: " + size[0] + "x" + size[1]);

for (i = 0; i < size[1]; i++) {
    for (j = 0; j < size[0]; j++)
        if (array[i,j] < 10) Console.Write(" " + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");
    Console.WriteLine();
}

//считаем сумму элементов в каждой строки и записываем их в отдельный массив
for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0] ; j++) {
        sum[i] = sum[i] + array[j,i];
    }

for (i = 0; i < size[1]; i++) {
    if (sum[i] > max) {
        max = sum[i];
        row_numb = i;
    }
}

Console.WriteLine();
Console.WriteLine("Сумма элементов по строкам: ");
for (i = 0; i < size[1]; i++) Console.Write(sum[i] + " ");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Сумма элементов строки максимальна в " + row_numb + " строке: ");

for (i = 0; i < size[0]; i++) Console.Write(array[row_numb, i] + " ");

Console.WriteLine();

