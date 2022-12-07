// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 1000);
    return array;
}

void Count(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    Console.WriteLine($"Количество четных чисел в массиве составляет - {sum}");
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