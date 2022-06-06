//Показать двумерный массив размером m×n заполненный вещественными числами

double [,] Matrix = new double [10,10];
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i,j] = Math.Round((new Random().NextDouble()) * 10,2);
            Console.Write(Matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}