Console.Write("Enter layers: ");
int layers = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,,] threeDArray = new int[layers, rows, columns];


for(int  i = 0; i < layers; i++)
{
    Console.WriteLine($"Elements for layer {i}");
    for(int j = 0; j < rows; j++)
    {
        for(int k = 0; k < columns; k++)
        {
            Console.Write($"3Darray[{j}, {k}]: ");
            threeDArray[i, j, k] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

for (int i = 0; i < layers; i++)
{
    for (int j = 0; j < rows; j++)
    {
        for (int k = 0; k < columns; k++)
        {
            Console.Write(threeDArray[i, j, k] + " ");

        }
        
        Console.WriteLine();
    } 
    Console.WriteLine();
}
