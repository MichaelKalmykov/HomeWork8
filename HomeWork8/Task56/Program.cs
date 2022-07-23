int [ , ] randArray = new int [3 , 4];
int minSum = Int32.MaxValue;
int minString = 0;
FillingArrayRandomValues(randArray);
PrintArray(randArray);
FindingMinString (randArray);



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
}
void FindingMinString (int [,] randArray)
{
    for (int i = 0; i < randArray.GetLength(0) ; i++)
    {
        int sumString = 0;
        for (int j = 1; j < randArray.GetLength(1); j++)
        {
            sumString = sumString + randArray[i, j];        
            if (sumString < minSum)
                {
                    minSum = sumString;
                    minString++;
                }
        }
    }
    Console.WriteLine(minString);
}
