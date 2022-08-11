// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = ReadInt("Введите X: ");
int y = ReadInt("Введите Y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("Номер четверти определить не удалось");
    return;
}

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка во 2 четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка в 4 четверти");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int numberQuarter = ReadInt("Введите номер Четверти: ");

if(numberQuarter == 1)
{
    Console.Write("Возможный диапазон X от 0 до бесконечности, Y от 0 до бесконечности.");
}
else if(numberQuarter == 2)
{
    Console.Write("Возможный диапазон X от 0 до -бесконечности, Y от 0 до бесконечности.");
}
else if(numberQuarter == 3)
{
    Console.Write("Возможный диапазон X от 0 до -бесконечности, Y от 0 до -бесконечности.");
}
else if(numberQuarter == 4)
{
    Console.Write("Возможный диапазон X от 0 до бесконечности, Y от 0 до -бесконечности.");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


///////////

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int lenghX = x1 - x2;
int lenghY = y1 - y2;
double distance = Math.Sqrt(lenghX * lenghX + lenghY * lenghY);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CheckLength (int a, int b)
{
    return b-a;
}

double dXdY (int a, int b)
{
    double sqrRes = Convert.ToDouble (a*a+b*b);
    return Math.Sqrt (sqrRes);
}

int x1 = ReadInt("Введите координату Х первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int x2 = ReadInt("Введите координату Х второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");

int xLength = CheckLength(x1, x2);
int yLength = CheckLength(y1, y2);

double result = dXdY(xLength, yLength);

Console.WriteLine("Расстояние между вашими точками: " + result);

/////////

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int lenghX = x1 - x2;
int lenghY = y1 - y2;
double distance = Math.Sqrt(lenghX * lenghX + lenghY * lenghY);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

////////////

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int lenghX = x1 - x2;
int lenghY = y1 - y2;
double distance = Math.Sqrt(lenghX * lenghX + lenghY * lenghY);
Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}) -> {distance}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sqr(int a)
{
    return a * a;
}

void SqrRange(int a)
{
    int number = 1;
    Console.Write("Ваша последовательность: ");
    while (number <= a)
    {
        Console.Write(Sqr(number) + " ");
        number++;
    }
}

int a = ReadInt("Введите число: ");
SqrRange(a);

