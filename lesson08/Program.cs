//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

/*int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(10, 100);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    
    }
    return array;
}

    int[,] myArray = CreateRandom2dArray();
    Show2dArray(myArray);
    myArray = SortedArray(myArray);
    Show2dArray(myArray);*/

//----------------------------------------------------------------------------------------------------------

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


/*int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(10, 100);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSum(int[,] array)
{
    int minsum = 99 * array.GetLength(1);
    int imin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            imin = i; 
        }   
    }
    return imin;
    
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int imin = MinSum(myArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов (для программистов): {imin}");*/

//------------------------------------------------------------------------------------------------

//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

/*int[,] CreateRandom2dArray(int k)
{
    Console.Write($"Введите количество строк матрицы {k}: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите количество матрицы {k}: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(1, 10);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array;
}

int[,] matrix1 = CreateRandom2dArray(1);
Show2dArray(matrix1);
int[,] matrix2 = CreateRandom2dArray(2);
Show2dArray(matrix2);
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] matrix = MultiplicationMatrix(matrix1, matrix2);
    Console.WriteLine("Реузультат: ");
    Show2dArray(matrix);
}
else
    Console.WriteLine("Матрицы нельзя перемножить. Для умножения необходимо, чтобы количество столбцов первой матрицы было равным количеству строк второй матрицы.");*/

//-------------------------------------------------------------------------------------------------

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

/*int[,,] CreateRandom3dArray()
{
    Console.Write("Введите размер Х: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер Z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    int[,,] newArray = new int[x, y, z];
    int num = 10;
    for (int i = 0; i < x; i++)
    {
        Console.Write($"Страница номер {i + 1})   ");
        Console.WriteLine();
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                newArray[i, j, k] = num;
                Console.Write($"{newArray[i, j, k]} ({i}, {j}, {k}) ");
                num++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return newArray;
}

int[,,] myArray = CreateRandom3dArray();*/

//-----------------------------------------------------------------------------------------------------

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

/*void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size, size];
int num = 1;
int i = 0;
int j = 0;
while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    num++;
}

Show2dArray(nums);*/
