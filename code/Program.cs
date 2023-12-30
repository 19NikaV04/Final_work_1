string[] size1 = new string[6] {"-2", "23", "hello", "world", "res", "Kazan"};
string[] size2 = new string[size1.Length];

void SecondArray(string[] size1, string[] size2)
{
    int count = 0;
    for (int i = 0; i < size1.Length; i++)
    {
        if(size1[i].Length <= 3)
        {
            size2[count] = size1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

SecondArray(size1, size2);
PrintArray(size2);
