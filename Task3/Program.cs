// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * (10 - 0);
    return array;
}

void Count(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным значением {max} и минимальным значением {min}  элементов в массиве составляет - {max - min}");
}

void PrintArray(double[] size)
{
    Console.Write("{ ");
    foreach (double el in size)
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
    double[] array = CreateArray(size);
    Console.WriteLine($"Сгенерирован массив из {size} элементов:");
    PrintArray(array);
    Count(array);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}