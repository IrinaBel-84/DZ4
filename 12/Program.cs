//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int b = 0;
while ( numb%10 > 0)
{
     
    b=b+numb%10;
    numb = numb/10;
}

Console.WriteLine($"{b}");