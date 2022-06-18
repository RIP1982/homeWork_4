// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] element = new int [8];

Console.Write("Array element[i] = {");
void PrintArray(int[] array)
{
    int massiveLength = array.Length;
    for (int i = 0; i < massiveLength; i++)
    {
        if (i < massiveLength - 1)
        {
            element[i] = new Random().Next(int.MinValue, int.MaxValue);
            Console.Write($"{array[i]}, ");
        }

        else if (i == massiveLength -1) 
        {
            element[i] = new Random().Next(int.MinValue, int.MaxValue);
            Console.Write($"{array[i]}");
            Console.Write("}");
        }
    }
}   
PrintArray(element); 
