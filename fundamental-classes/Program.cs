Console.Write("Enter the row size of the jagged array: ");
int rows = Convert.ToInt32(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

int sum = 0;

Console.WriteLine("Enter the size(s) of the array for each row: ");
for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write($"row {i + 1} length: ");
    int length = Convert.ToInt32(Console.ReadLine());
    jaggedArray[i] = new int[length];

    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"row[{j}]: ");
        jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
        sum += jaggedArray[i][j];
    }
}
Console.WriteLine(sum);


//for(int i = 0; i < jaggedArray.Length; i++)
//{
//    for(int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        Console.Write(jaggedArray[i][j] + " ");
//    }
//    Console.WriteLine();
//}

foreach(var row in jaggedArray)
{
    foreach(var value in row)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}