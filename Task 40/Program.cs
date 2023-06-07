// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A < B+C && B < A+C && C < A+B)
System.Console.WriteLine("Треугольник существует"); 
else
System.Console.WriteLine("Треугольник не сущестует");


