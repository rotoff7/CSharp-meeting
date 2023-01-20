int[] bigmassive = { 12, 5, 1, 7, 8, 2, 25, 2 };
int index = 0;
int size = bigmassive.Length;
int sortsize = size;
int count = 0;
while (count
 < size)
{
    int max = 0;
    int maxPos = index;
    while (index < size)
    {
        if (bigmassive[index] > max)
        {
            max = bigmassive[index];
            maxPos = index;
        }
        index++;
    }
    int help = bigmassive[sortsize - 1];
    bigmassive[sortsize - 1] = max;
    bigmassive[maxPos] = help;
    sortsize = sortsize - 1;
    count++;
}
var massive2_0 = string.Join(" ", bigmassive);
Console.WriteLine(massive2_0);
