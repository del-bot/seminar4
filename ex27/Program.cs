int numberDivide(int number)
{
    int count = Convert.ToString(number).Length;
    int memor = 0;
    int summ = 0;
    for ( int i = 0; i < count; i++)
    {
        memor = number % 10;
        summ =  memor + summ; 
        number/=10;
    }
    Console.WriteLine($"summ is {summ}");
    return summ;   
}

Console.WriteLine("input your number");
int userNumber = Convert.ToInt32(Console.ReadLine());

numberDivide(userNumber);
