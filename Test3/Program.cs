// Имеется одномерный массив array из n элементов. Требуется найти элемент массива, равный find

int[] array = { 1, 12, 51, 4, 18, 13, 18, 19 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++; 
}

