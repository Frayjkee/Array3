using System;

class Program
{
    static void Main()
    {
        // Генерируем массив из 10 случайных вещественных чисел
        double[] numbers = GenerateRandomNumbers(10, 1, 101);

        // Находим максимальный и минимальный элементы массива
        double maxNumber = FindMax(numbers);
        double minNumber = FindMin(numbers);

        // Находим разницу между максимальным и минимальным элементами
        double difference = maxNumber - minNumber;

        // Выводим сгенерированный массив и результат
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);
        Console.WriteLine($"Максимальный элемент: {maxNumber}");
        Console.WriteLine($"Минимальный элемент: {minNumber}");
        Console.WriteLine($"Разница: {difference}");
    }

    // Функция для генерации массива случайных вещественных чисел
    static double[] GenerateRandomNumbers(int count, double minValue, double maxValue)
    {
        Random random = new Random();
        double[] numbers = new double[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);
        }

        return numbers;
    }

    // Функция для вывода массива на консоль
    static void PrintArray(double[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Функция для нахождения максимального элемента в массиве
    static double FindMax(double[] array)
    {
        double max = array[0];
        foreach (var number in array)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    // Функция для нахождения минимального элемента в массиве
    static double FindMin(double[] array)
    {
        double min = array[0];
        foreach (var number in array)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }
}
