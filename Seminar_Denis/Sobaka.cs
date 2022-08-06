/*
double dist = 1000,
       time = 0;
int firstFriendSpeed = 10,
    secondFriendSpeed = 10,
    dogSpeed = 10,
    friend = 2,
    count = 0;

while (dist > 10)
{
    if (friend == 1)
    {
        time = dist / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = dist / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    dist -= (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит " + count + " раз");


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;


while(startNumber <= number)
    {
        if(startNumber % 2 ==0)
        Console.Write(startNumber + ", ");
        startNumber ++;
    }
    */