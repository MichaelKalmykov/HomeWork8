int size = 4;
int [ , ] array = new int [4 , 4];
FindingMinString(array);
PrintArray(array);

void FindingMinString (int [ , ] array)
{
    int value = 1;
    int i = 0;
    int j = 0; 
    while (value <= size * size)
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size-1)
        {
            ++j;
        }
        else if (i < j && i + j >= size - 1)
        { 
            ++i;
        }
        else if (i >= j && i + j > size - 1)
        {
            --j;
        }
        else
        {
            --i;
        }
        value++;
    }
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("(");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j] + " ");
        }
        Console.Write(")");
        Console.WriteLine("");
    }
}