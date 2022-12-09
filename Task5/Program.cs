// Задача 30: - HARD необязательная 
// Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности, применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы со списками использовать нельзя.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    int count = 1;
    array[0] = new Random().Next(0, size + 1);
    for (int i = 1; i < size; i++)
    {
        array[i] = new Random().Next(0, size + 1);
        for (int j = 0; j < count; j++)
        {
            while (array[j] == array[i])
            {
                array[i] = new Random().Next(0, size + 1);
                j = 0;
            }
        }
        count++;
    }
    return array;
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

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    Console.WriteLine($"Сгенерирован массив из {size} элементов:");
    PrintArray(array);
    Console.WriteLine($"Отсортирован первоначальный массив от большего к меньшему:");
    PrintArray(ChangeArray(array));

}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}