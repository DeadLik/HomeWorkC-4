// Задача 27: Напишите программу, 
// 1. которая принимает на вход число 
// 2. и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int res = num % 10;
        num /= 10;
        sum += res;
    }
    return sum;
}

if (number > 0)
{
    int result = SumOfDigits(number);
    Console.WriteLine($"Сумма всех цифр в числе {number} = {result}");
}
else Console.WriteLine("Введите положительное число, например (82)");
