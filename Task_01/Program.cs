// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Input the number of array elements: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void CreateArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Input {i + 1} array element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int SumOfNaturalElem(int[] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
            sum += 1; i++;
        }
    return sum;
}

CreateArray(m);
PrintArray(array);
Console.Write($"\b\b -> {SumOfNaturalElem(array)}");