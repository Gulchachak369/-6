// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0; // сосоед 3
int num1 = 0; // сосоед 1
int num2 = 1; // сосоед 2

System.Console.Write("0 1 ");

for (int i = 2; i < n; i++)
{
    res = num1 + num2;
    num1 = num2; // смещаемся на единицу
    num2 = res;
    System.Console.Write($"{res} ");
}
