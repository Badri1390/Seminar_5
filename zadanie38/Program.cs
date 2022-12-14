// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
double[] array = FillArrayWithRandomNumbers(5, 2, 12);
double sum = ElementDifference(array);
System.Console.WriteLine();
System.Console.WriteLine(sum);

double ElementDifference(double[] arr)
{
    double diff = 0;
    double max = 0;
    double min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
    System.Console.WriteLine();
    System.Console.WriteLine("Максимальное число: " + max + "  Минимальное число: " + min);
    diff = max - min;
    return diff;
}


double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] tempArr = new double[size];
    Random rand = new Random();
        for (int i = 0; i < tempArr.Length; i++)
        {
            tempArr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
        }

    System.Console.Write(("[" + string.Join("; ", tempArr) + "]"));
    return tempArr;
}