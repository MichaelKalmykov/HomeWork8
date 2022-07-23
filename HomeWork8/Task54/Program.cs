int [ , ] randArray = new int [3 , 4];
FillingArrayRandomValues(randArray);
PrintArray(randArray);
SortingArray (randArray);
PrintArray(randArray);



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
    Console.WriteLine("Не отсортированый массив");
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
void SortingArray (int [,] randArray)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Отсортированый массив");
    for (int a = 0; a < randArray.Length; a++)
    {
        for (int i = 0; i < randArray.GetLength(0); i++)
        {
            for (int j = 0; j+1 < randArray.GetLength(1); j++)
            {
                if (randArray[i,j] < randArray[i,j+1])
                {
                    int buff = 0;
                    buff = randArray[i, j];
                    randArray[i, j] = randArray[i, j + 1];
                    randArray[i, j + 1] = buff;
                }
            }
        } 
    }   
}
