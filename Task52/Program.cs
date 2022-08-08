int m = 0;
int n = 0;
Console.Write("Введите количество рядов: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите количество столбцов: ");
int.TryParse(Console.ReadLine(), out n);
int [,] array = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
      array[i,j] = new Random().Next(10);  
    }
}



void PrintArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
PrintArray(array);
void FindAverageColumns (int [,] array)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[j,i];
            average = Math.Round((sum/n),1);
            
        }
        Console.Write($"{average}; ") ;
        sum = 0;
    }
}
FindAverageColumns(array);