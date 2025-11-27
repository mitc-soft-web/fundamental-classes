int[] p1 = { -1, 5, 3 };
int[] p2 = { -5, 2 };
int[] p3 = { -4, 2 };

int[] result = Polynomia(p1, p2, p3);
Console.WriteLine(string.Join(" ", result));


static int[] Polynomia(int[] p1, int[] p2, int[] p3)
{
    int maxLength = Math.Max(p1.Length, Math.Max(p2.Length, p3.Length));
    int[]sum = new int[maxLength];

    for(int i = 0; i< maxLength; i++)
    {
        int c1 = i < p1.Length ? p1[i] : 0;
        int c2 = i < p2.Length ? p2[i] : 0;
        int c3 = i < p3.Length ? p3[i] : 0;

        sum[i] = c1 + c2 + c3;
    }

    return sum;
}