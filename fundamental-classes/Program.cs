int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
int[] arr2 = { 1, 2, 3, 4};

int countElement = 0;
for(int i = 0; i < arr1.Length; i++)
{
    if (arr2.Contains(arr1[i])) continue;
    countElement++;
}

int[] newArr = new int[arr2.Length + countElement];

for(int i = 0; i < arr2.Length; i++)
{
    newArr[i] = arr2[i];
}

int index = arr2.Length;

for(int i = 0; i < arr1.Length; i++)
{
    if(arr2.Contains(arr1[i])) continue;
    if (newArr.Contains(arr1[i])) continue;
    newArr[index] = arr1[i];
    index++;
}

foreach(var num in newArr)
{
    if (num == 0) continue;
    Console.WriteLine(num);
}