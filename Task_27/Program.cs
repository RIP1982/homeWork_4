// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10

Console.Clear();

int number = Input("Input number: ");
int sum = 0;

while (number > 0)
{
    int div = number % 10;
    sum = sum  + div;
    number = number / 10;
}

Console.WriteLine($"Sum of digits = {sum}");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
