// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void Array(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int AmountNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
            sum++;
    }
    return sum;
}
Array(size);
Console.WriteLine($"Чисел больше нуля: {AmountNumber(array)}");