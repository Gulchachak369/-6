// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

int[] MethodCopyArray(int length, int[] array)
{
    int[] arraycopy = new int[length];
    for (int j = 0; j < length; j++)
    {
        arraycopy[j] = array[j];
    }
    return arraycopy;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

int[] res = MethodCopyArray(length, array);
System.Console.WriteLine(string.Join(", ", res));