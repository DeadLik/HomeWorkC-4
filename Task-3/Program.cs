// Задача 29: Напишите программу, 
// 1. которая задаёт массив из 8 элементов 
// 2. и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
int[] arrayFilledIn = { 1, 2, 5, 7, 19, 6, 1, 33 };

Console.WriteLine("Выберите заполненный массив или случайный, напишите нужную цифру \n1 -> заполненный \n2 -> случайный");
int choice = Convert.ToInt32(Console.ReadLine());

void FillingTheArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int rnd = new Random().Next(1, 33);
        arr[i] = rnd;
    }
}

void PrintArrayForeach(int[] arr) // Интересно было попробовать через foreach
{
    Console.Write("[");
    foreach (int myArrays in arr)
    {
        Console.Write(" " + myArrays + " ");
    }
    Console.Write("]");
}

void PrintArrayFor(int[] arr) // Стандартно через for
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(" " + arr[i] + " ");
    }
    Console.Write("]");
}


if (choice == 1)
{
    PrintArrayForeach(arrayFilledIn);
    Console.WriteLine();
    PrintArrayFor(arrayFilledIn);
}
else if (choice == 2)
{
    FillingTheArray(array);
    PrintArrayForeach(array);
    Console.WriteLine();
    PrintArrayFor(array);
}
else Console.Write("Вы ввели неверный ответ");




