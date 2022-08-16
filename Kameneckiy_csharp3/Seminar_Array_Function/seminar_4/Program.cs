// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
int sum = 0;

while (index <= number)
{
sum += index++;
}
Console.WriteLine(sum);

/* for ( int i =0 ; i <= index ; i++)
    {
        sum +=i ;
    }
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    456 -> 3
    78 -> 2
    89126 -> 5
*/
int number = ReadInt("Введите число ");
int index = 0;

while (number > 0)
    {
        int result = number /= 10;
        index++;
    }

Console.WriteLine(index);

int ReadInt(string message)
{
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
}

///////////////////

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(number > 0)
{
number /= 10;
count++;
}

Console.WriteLine(count);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
    4 -> 24
    5 -> 120
*/

int number = ReadInt("Введите число ");
int result = 1;

for (int i = 1; i <= number; i++)
{
    result *= i;
}

Console.WriteLine(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

////////////////////////

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int multiply = 1;

for (int i = 1; i <= number; i++)
{
multiply *= i;
}

Console.WriteLine(multiply);

/* ФАКТОРИАЛ ЧИСЛА N */

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
    [1,0,1,1,0,1,0,0]
*/

int[] array = new int[8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}

Console.Write(array[i] + " ");

//////////////////////

int[] GenerateArray ()
{
int[] array = new int [8];
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 2);
}
return array;

}

void PrintArray (int[] Array)
{
for(int i = 0; i < Array.Length; i++)
{
Console.Write(Array[i] + " ");
}
}

PrintArray(GenerateArray());

//////////////////////

int size = 8;
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 2);
}

PrintArray(array);

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}

///////////////////////

// Решение преподавателя с дополнительнынми методами

int size = 8;
int[] array = new int[size];

FillArrayRandomNumbers(array);
PrintArray(array);

void FillArrayRandomNumbers(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 2);
}
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////