// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("введите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
for (int i = 0; i < B; i++)
{
    C = C*A;
}
Console.WriteLine(C);