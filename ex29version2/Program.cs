void CreateNewArray(int  size_array)
{
    int []array = new int [size_array];
    for (int i = 0; i <size_array; i++)
    {
        Console.WriteLine($"input element of array with index {i} ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i =0; i<size_array; i++)
        Console.Write(array[i] + " ");
    
}
CreateNewArray(8);