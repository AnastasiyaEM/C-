// Найти элемент массива, равный find

int[] array = { 1, 12, 31, 14, 58, 65, 78, 89, 58 };

int n = array.Length;
int find = 58;

int index = 0;

while (index <  n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
