// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 100);
    return array;
}

void Count(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма значений стоящих на нечетных позициях в массиве составляет - {sum}");
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

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    Console.WriteLine($"Сгенерирован массив из {size} элементов:");
    PrintArray(array);
    Count(array);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}