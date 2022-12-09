// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначального массива, возможно придется кое-что для этого дополнительно выполнить.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 1000);
    return array;
}

void Count(int[] array)
{
    int max = array[0];
    int imax = 0;
    int min = array[0];
    int imin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            imax = i;
        }
    }
    for (int j = 0; j < array.Length; j++)
        if (array[j] < min)
        {
            min = array[j];
            imin = j;
        }
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    int average = sum / array.Length;
    Console.WriteLine($"Максимальное значение массива = {max} его индекс = {imax}");
    Console.WriteLine($"Минимальное значение массива = {min} его индекс = {imin}");
    Console.WriteLine($"Среднее арифметическое всех элементов массива составляет = {average}");
}

void PrintArray(int[] size)
{
    Console.Write("{ ");
    foreach (int el in size)
    {
        Console.Write($"{el} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

int[] ChangeArray(int[] size)
{
    int[] new_array = new int[size.Length];
    for (int i = 0; i < size.Length; i++)
    {
        new_array[i] = size[i];
    }
    return new_array;
}

int[] ChangeArray2(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        int max_pos = i;
        for (int j = i + 1; j < size.Length; j++)
        {
            if (size[j] > size[max_pos]) max_pos = j;
        }
        int temp = size[i];
        size[i] = size[max_pos];
        size[max_pos] = temp;
    }
    return size;
}

void MedianFind(int[] size)
{
    int imedian = 0;
    int median = 0;
    if (size.Length % 2 != 0)
    {
        imedian = size.Length / 2;
        median = size[imedian];
    }
    else
    {
        median = (size[size.Length / 2] + size[size.Length / 2 - 1]) / 2;
    }
    Console.WriteLine($"Медианное значение первоначального массива составляет = {median}");
}

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    Console.WriteLine($"Сгенерирован массив из {size} элементов:");
    PrintArray(array);
    Count(array);
    ChangeArray(array);
    Console.WriteLine($"Отсортирован первоначальный массив:");
    PrintArray(ChangeArray2(array));
    MedianFind(ChangeArray2(array));
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}