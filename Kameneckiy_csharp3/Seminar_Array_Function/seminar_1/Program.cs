// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

/*
int randomNumber = new Random().Next(100,1000);
Console.WriteLine(randomNumber);
int firstDigitRandomNumber = randomNumber / 100 % 10;
int secondDigitRandomNumber = randomNumber % 10;
Console.Write(firstDigitRandomNumber + "" + secondDigitRandomNumber);


int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);
Console.WriteLine(DeleteSecondDigit(randomNumber));

int DeleteSecondDigit(int number)
{
    int first = number / 100;
    int third = number % 10;
    return first * 10 + third;
}

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}



*/
/*
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int firstNumber = ReadInt("Первое число: ");
int secondNumber = ReadInt("Второе число: ");

int remainderOfDivision = firstNumber % secondNumber;
if (remainderOfDivision == 0)
{
	Console.WriteLine("Числа кратны");
}
else
{
	Console.WriteLine("Числа не кратны, остаток от деления - " + remainderOfDivision);
}


int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}

*/

