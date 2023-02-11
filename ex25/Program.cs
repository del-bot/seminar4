int Cycle(int a, int b)
{
    int i = 1;
    int newNumber = 1;
    while ( i <= b )
    {
        newNumber = newNumber * a;
        i++;
    }
 Console.WriteLine($"degree of element {a} is {newNumber}");
 return newNumber;
}

Console.WriteLine("input your number a");
int userA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input your number b");
int userB = Convert.ToInt32(Console.ReadLine());


if ( userB >= 0)
{
    Cycle(userA,userB);
  
}       
else Console.WriteLine("uncorrect number");