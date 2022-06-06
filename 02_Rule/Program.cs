//Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Clear();

Console.WriteLine("Введите кол-во строк двумерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] Matrix = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Matrix[i,j] = i+j;
        Console.Write(Matrix[i,j] + " ");
    }
    Console.WriteLine();
}