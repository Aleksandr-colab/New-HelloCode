// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
// 1. Установить счетчик index в позицию 0
// 2. Если array [index] = find, алгоритм завершил работу успешно.
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. В противном случае
// алгоритм завершил работу безуспешно.
int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};

int n = array.Length;
int find = 19;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}