Console.Write("Enter length for layer: ");
int layers;

Console.Write("Enter the length for row: ");
int rows;

while(!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine("Enter valid value for rows!");
}

Console.Write("Enter the length for column: ");
int columns;

while (!int.TryParse(Console.ReadLine(), out columns))
{
    Console.WriteLine("Enter valid value for colums!");
}


int[,] arr = new int[rows, columns];

Console.WriteLine("Enter element for rows and colums...");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"arr[{i}, {j}]: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }




