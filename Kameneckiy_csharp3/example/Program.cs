string separatedNumbers = ReadCommand("Введите числа через запятую: ");
int[] numbers = new int[separatedNumbers.Length];

int count = 0;
for (int i = 0; i < separatedNumbers.Length; i++)
{
    numbers[i] = separatedNumbers[i];
    if (numbers[i] > 0 && numbers[i] != ',') count++;
}
Console.Write(count);

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}



///////////////////////////////////////////////////////////////////////////////////////////////////////

int CountCommas(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ',')
            counter++;
    return counter;
}

int CountMinuses(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == '-')
            counter++;
    return counter;
}

int CountZeros(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == '0')
            counter++;
    return counter;
}

//--------MAIN-----------//
Console.Write("Введите цифры через запятую: ");
string userInput = Console.ReadLine() + ",";
userInput = userInput.Replace(" ", "");
int numbersCount= CountCommas(userInput);
if (userInput.Length==numbersCount)
    {
        Console.Write ("Цифр не обнаружено...");
        return;
    }
int zeros = CountZeros(userInput);
int minuses = CountMinuses(userInput);
Console.WriteLine (numbersCount-zeros-minuses);