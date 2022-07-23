int [ , ] randArrayA = new int [3 , 4];
int [ , ] randArrayB = new int [3 , 4];
FillingArrayRandomValues(randArrayA);
FillingArrayRandomValues(randArrayB);
Console.WriteLine("Первый массив");
PrintArray(randArrayA);
Console.WriteLine("Второй массив");
PrintArray(randArrayB);
int [ , ] multipliedArray = new int [3 , 4];
Multiplied (multipliedArray);
Console.WriteLine("Итоговый массив");
PrintArray(multipliedArray);


void FillingArrayRandomValues(int [ , ] randArray)
{
    Random rand = new Random();
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
         randArray [ i, j] = Convert.ToInt16(new Random().Next(0, 10));
        }
    }
}
void PrintArray (int [,] randArray)
{
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        Console.Write("(");
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            Console.Write(" " + randArray[i, j] + " ");
        }
        Console.Write(")");
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
void Multiplied (int [ , ] multipliedArray)
{
    for (int i = 0; i < multipliedArray.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedArray.GetLength(1); j++)
        {
            multipliedArray[ i, j ] = randArrayA[ i, j ] * randArrayB[ i, j ];
        }
    }
}