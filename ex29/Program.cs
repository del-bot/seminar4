int [] CreateNewArray(int size_array)
{
    int [] random01array = new int [size_array];
    for (int i= 0; i < size_array; i++)
    {
        random01array[i] = new Random().Next(0, 40);
    }
    return random01array;
}

void ShowCreatedArray(int [] array01)
{
    for (int i = 0; i < array01.Length; i++)
        Console.WriteLine(array01[i] + " ");
}
ShowCreatedArray(CreateNewArray(8));
