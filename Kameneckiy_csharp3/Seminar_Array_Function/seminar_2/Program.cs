// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет"); 
}
   




int number = ReadInt("Введите число: ");
int firstDivider = 7;
int secondDivider = 23;
if(Multiple(number, firstDivider) && Multiple(number, secondDivider))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool Multiple(int a, int b)
{
    return a % b == 0;
}

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}


/* 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber / secondNumber == secondNumber || secondNumber / firstNumber == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");
}





int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

if(Sqr(firstNumber) == secondNumber || Sqr(secondNumber) == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int Sqr(int number)
{
    return number * number;
}

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}
