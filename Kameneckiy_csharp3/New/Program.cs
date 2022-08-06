// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()),
    antiNumber = 0 - number;

while (antiNumber <= number)
{
    Console.Write(antiNumber);
    antiNumber ++;
}
*/


//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
    //456 -> 6
	//782 -> 2
	//918 -> 8

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 10);

