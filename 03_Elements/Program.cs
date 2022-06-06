//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int [,] Matrix = new int [5,5];
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        Matrix[i,j] = new Random().Next(1,10);
    }
}
void PrintArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] Replace (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if( i % 2 == 0 && j % 2 == 0)
            array[i,j] *= array[i,j];

        }
    }
    return array;
}
PrintArray(Matrix);
Console.WriteLine();
PrintArray(Replace(Matrix));
