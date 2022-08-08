int m = 0;
int n = 0;
Console.Write("Введите количество рядов: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите количество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

double [,] array = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Random rand = new Random();
        array [i,j] = rand.Next(-100,100)+rand.NextDouble();   
    }
}
void PrintArray(double[,]array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{Math.Round(array[i,j],1)} ");
             
        }
        Console.WriteLine();
    }
    
}
PrintArray(array);