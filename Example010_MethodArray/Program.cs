int[] Array = { 16, 232, 4, 35, 476, 324, 2, 4, 8213 };

int n = Array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (Array[index] == find)
    {        
        Console.WriteLine(index);
        break;
    }
    index ++;
}