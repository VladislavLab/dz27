// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// программа выводит массив из 8 элементов , заполненный нулями и единицами в случайном порядке

int[] GetArray()//создание и заполнение массива
{
    int[] array = new int[9];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);

    }
    return array;
}

void PrintArray(int[] inarray) //печать массива
{
    for (int i = 0; i < inarray.Length; i++)
    {
        Console.Write($" {inarray[i]}");
    }

}
void LPrintArray(int[] inarray) //печать массива

{

    for (int i = 0; i < inarray.Length; i++)
    {
        Console.Write($" {inarray[i]}");
    }
}
Console.Clear();

int[] array = GetArray();
Console.Write("[");
PrintArray(array);
Console.Write(" ]");

