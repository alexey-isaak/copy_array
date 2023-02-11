void print_array(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}

int[] create_array(int length, int lowest, int hightest)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest, hightest + 1);
    return array;
}

int[] copy_array(int[] array) 
{
    int array_length = array.Length;
    int[] copy_array = new int[array_length];
    for (int i = 0; i < array.Length; i++)
    {
        copy_array[i] = array[i];
    }
    return copy_array;

}
int[] array = create_array(10, 1, 99);

Console.Write("Исходный массив: ");
print_array(array);
Console.Write("Копия массива: " );
print_array(copy_array(array));
