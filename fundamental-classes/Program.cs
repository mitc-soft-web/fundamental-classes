Console.Write("Enter length for array1: ");
int length1 = Convert.ToInt32(Console.ReadLine());

char[] array1 = new char[length1];

Console.Write("Enter length for array2: ");
int length2 = Convert.ToInt32(Console.ReadLine());

char[] array2 = new char[length2];


int length = int.Min(length1, length2);

Console.WriteLine("Enter elements for array1: ");
for(int i = 0; i < array1.Length; i++)
{
    Console.Write($"Array1[{i}]: ");
    array1[i] = Convert.ToChar(Console.ReadLine());
}

Console.WriteLine("Enter elements for array2: ");
for(int i = 0; i < array2.Length; i++)
{
    Console.Write($"Array2[{i}]: ");
    array2[i] = Convert.ToChar(Console.ReadLine());
}

string result = "";

for(int i = 0; i < length; i++)
{
    if(array1[i] > array2[i])
    {
        result = "Array2 comes first in lexicographical order";
        break;
    }
    else if(array1[i] < array2[i])
    {
        result = "Array1 comes first in lexicographical order";
        break;
    }
    else
    {
        if(array1.Length > array2.Length)
        {
            result = "Array2 comes first in lexicographical order";
        }
        else if(array1.Length < array2.Length)
        {
            result = "Array1 comes first in lexicographical order";
        }
        else
        {
            result = "Array1 and Array2 are equal";
        }
    }
}


Console.WriteLine(result);