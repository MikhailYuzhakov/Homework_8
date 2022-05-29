/*
Задача 62: Заполните спирально массив 4 на 4.
*/

int[,] array = new int[1000,1000];
int i = 0, j = 0, numb = 1;
int m = 7; //количество строк
int n = 7; //количество столбцов

//заполняем периметр
for (i = 0; i < m; i++) {
    array[0, i] = numb;
    numb++;
}

for (i = 1; i < n; i++) {
    array[i, n - 1] = numb;
    numb++;
}

for (i = m - 2; i >= 0; i--) {
    array[m - 1, i] = numb;
    numb++;
}

for (i = n - 2; i >= 1; i--) {
    array[i, 0] = numb;
    numb++;
}

i = 1;
j = 1;

//заполняем остальные элементы внутри
while (numb < m * n) {
    while (array[i, j + 1] == 0) {
        array[i,j] = numb;
        numb++;
        j++;
    }

    while (array[i + 1, j] == 0) {
        array[i,j] = numb;
        numb++;
        i++;
    }

    while (array[i, j - 1] == 0) {
        array[i,j] = numb;
        numb++;
        j--;
    }

    while (array[i - 1, j] == 0) {
        array[i,j] = numb;
        numb++;
        i--;
    }
}

//при m и n нечетных, остается 0 посередине, находим и заполняем
for (i = 0; i < m; i++) {
    for (j = 0; j < n; j++) {
        if (array[i,j] == 0) {
            array[i,j] = numb;
            numb++;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Заполненый массив: ");

//выводим массив
for (i = 0; i < m; i++) {
    for (j = 0; j < n; j++)
        if (array[i,j] < 10) Console.Write(" " + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");
    Console.WriteLine();
}


