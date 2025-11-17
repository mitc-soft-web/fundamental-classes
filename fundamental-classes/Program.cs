int[] numbers = { 3, 3, 3, 1, 2, 1, 2, 3, 3, 2, 2, 1, 3, 1, 3, 1, 2, 2, 3, 3, 3 };
int value = 0;
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int currentCount = 1;

    for(int j  = i+ 1; j < numbers.Length; j++)
    {
        if(numbers[i] == numbers[j])
        {
            currentCount++;
        }
    }
    
    if(currentCount > count)
    {
        count = currentCount;
        value = numbers[i];

    }
}

Console.WriteLine($"{value} appears {count} times");