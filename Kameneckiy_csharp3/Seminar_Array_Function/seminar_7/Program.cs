
// // // домашняя работа 41

Console.WriteLine("Введите числа через запятую: ");
string input = Console.ReadLine();

int[] numbers = ParseStringToArray(input);
PrintArray(numbers);

int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}
int GetCountNumbersInString(string input) 
{
    int count;
    if(input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 9);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

int ReadInt (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i+j;
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*---------------MAIN--------*/

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int [rows,cols];
FillArray2D(numbers);
PrintArray2D(numbers);

// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// // Например, изначально массив
// //  выглядел вот так:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Новый массив будет выглядеть 
// // вот так:
// // 1 4 7 2
// // 5 81 2 9
// // 8 4 2 4


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];

FillArray2D(array);
PrintArray2D(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 1 && j % 2 == 1)
        {
            array[i, j] *= array[i, j];
        }
    }

}
PrintArray2D(array);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

///////////////

//решение преподавателя
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] numbers = new int[rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);

for (int i = 1; i < numbers.GetLength(0); i+=2)
{
    for (int j = 1; j < numbers.GetLength(1); j+=2)
    {
        numbers[i, j] *= numbers[i, j];
    }
}
Console.WriteLine();
PrintArray2D(numbers);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rowsNumber = ReadInt("Введите количество строк: ");
int columnsNumber = ReadInt("Введите количество столбцов: ");
int[,] arrayNumbers = new int[rowsNumber, columnsNumber];
int sumElements = 0;

FillArray2D(arrayNumbers);

for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        if (i == j)
        {
            sumElements += arrayNumbers [i,j];
        }
    }
}

PrintArray2D(arrayNumbers);
Console.WriteLine (sumElements);

void FillArray2D(int[,] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            arrayNumbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] aarrayNumbers)
{
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            Console.Write(arrayNumbers[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

////////////////

// решение преподавателя
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] numbers = new int[rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);
int sum = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if(i == j)
        {
            sum += numbers[i, j];
            break;
        }
    }
}
Console.WriteLine();
Console.WriteLine(sum);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

/////////////

//решение преподавателя(2)
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] numbers = new int[rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);
int sum = 0;
int size = 0;
if(numbers.GetLength(0) < numbers.GetLength(1))
{
    size = numbers.GetLength(0);
}
else
{
    size = numbers.GetLength(1);
}

for (int i = 0; i < size; i++)
{
    sum += numbers[i, i];
}

Console.WriteLine();
Console.WriteLine(sum);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////