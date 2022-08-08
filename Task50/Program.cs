int m = 5;
int n = 6;
int[,] array = new int[m,n];
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

int positionRows = 0;
Console.Write("Enter position in rows: ");
int.TryParse(Console.ReadLine(), out positionRows);
int positionColumns = 0;
Console.Write("Enter position in columns: ");
int.TryParse(Console.ReadLine(), out positionColumns);
int PrintNumber(int [,] array)
{
  if (positionRows<m && positionColumns<n )
  {
    return array[positionRows,positionColumns];
  }
  return -1;
 }
void CheckInBoundaries (int [,]array)
{
  if (positionRows>=m || positionRows<0|| positionColumns>=n|| positionColumns<0) Console.WriteLine("Такого числа не существует");
  else Console.WriteLine(PrintNumber(array));
}
CheckInBoundaries(array);

