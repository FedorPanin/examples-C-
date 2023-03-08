int[] array = { 1, 12, 31, 4, 5, 6, 7, 12 };

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;   // прерывает поиск в случае если несколько элементов имеют одинаковое значение, останавливается на первом
    }
    index++;
}
