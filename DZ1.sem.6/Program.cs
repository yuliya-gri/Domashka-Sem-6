// пользователь вводит с клавиатуры М чисел.
// посчитать сколько чисел больше нуля ввел пользователь

int[] CreatArray(int M)
{
    int[] array = new int[M];
    for(int i = 0; i < M; i++)
    {
          Console.WriteLine("Введите элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int ElCount(int[] array)
{
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count = count + 1;
    }
}
 return count;
}
Console.WriteLine("Введите количество элементов массива");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = CreatArray(M);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Количество чисел больше нуля равно {ElCount(array)}");