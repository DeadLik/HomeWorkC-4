// Задача 25: Напишите цикл, который принимает 
// 1. на вход два числа (A и B) и возводит число A 
// 2. в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16


Console.Write("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());


int DegreeB(int a, int b)
{
    int step = a;
    for (int i = 1; i < b; i++)
    {
        step *= a;
    }
    return step;
}

if (a > 0 && b > 0)
{
    int result = DegreeB(a, b);
    Console.WriteLine($"A в степени B равно: {result}");
}
else Console.WriteLine("Введите положительные числа, например (2, 4)");




