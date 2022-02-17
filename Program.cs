// Задача 30: Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Дан массив из чисел:");
double[] array = { 342, 237, 32, 41, 54, 611, 78, 83, 94 };
double count = array.Length;
for (int i = 0; i < count; i++)
    Console.Write($" {array[i]}");
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        Console.WriteLine($"Куб числа {array[i]}: {array[i]} * {array[i]} * {array[i]} = {array[i] * array[i] * array[i]}");
}