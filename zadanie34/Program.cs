// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] arr = FillArrayWithRandomNumbers(4, 100, 300);
int sum = Counter(arr);
System.Console.WriteLine();
System.Console.WriteLine("Кол-во чётных чисел: " + sum);

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random rand = new Random();
        for (int i = 0; i < tempArr.Length; i++)
        {
            tempArr[i] = rand.Next(leftRange, rightRange + 1);
        }

    System.Console.Write(("[" + string.Join(", ", tempArr) + "]"));
    return tempArr;
}


int Counter(int[] array)
{
    int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] % 2) == 0)
            {
                count++;
            }
        }
    return count;
}
