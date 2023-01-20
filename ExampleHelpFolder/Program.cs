int defaultvalue = 20;
int[] bigmassive = new int [defaultvalue];
int ifill = 0;
while (ifill < defaultvalue)
{
bigmassive[ifill] = new Random().Next(1,99);
ifill++;
}


int count = 0;
int size = bigmassive.Length;
int sortsize = size;
while (count < size)
{
    int index = 0;
    int max = 0; //
    int maxPos = 0; //
    while (index < sortsize)
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
