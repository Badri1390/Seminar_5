// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.Clear();
int [] array = FillArrayWithRandomNumbers(7, 1, 13);
int summa = ElementSum(array);
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов, стоящих на нечётных позициях:  " + summa);

int ElementSum(int[] arr)
{
    int sum = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            sum = sum + arr[i++];
        }
    return sum;
}


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
