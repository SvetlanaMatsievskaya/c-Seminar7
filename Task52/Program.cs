int m = 0;
int n = 0;
int [,] array = new int[m,n];
Console.WriteLine("Введите количество рядов: ");
int.TryParse(Console.WriteLine(), out m);
Console.WriteLine("Введите количество столбцов: ");
int.TryParse(Console.WriteLine(), out n);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
      array[i,j] = new Random().Next(10);  
    }
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}