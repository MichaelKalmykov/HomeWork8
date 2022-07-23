int[,,] array3D = new int[3, 3, 3];
FillingArrayRandomValues(array3D);
PrintArray(array3D);

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int a = 0; a < array3D.GetLength(2); a++)
            {
                Console.WriteLine($"[{i},{j},{a}] - {array3D[i, j, a]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void FillingArrayRandomValues(int [ , , ] array3D)
{
    Random rand = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int a = 0; a < array3D.GetLength(2); a++)
            {
                array3D [ i, j, a] = Convert.ToInt16(new Random().Next(10, 100));
            }
        }
    }
}