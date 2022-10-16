int[] array = { 11, 21, 31, 18, 4, 15, 61, 17, 18 };

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    
    {
        Console.WriteLine(index);
        break; // чтобы найти самый первый элемент в массиве
    }
    index++;
}        

