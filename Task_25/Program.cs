// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int A = Input("Input number A: ");
int B = Input("Input number B: ");


double square(double a, double b)
{
   return Math.Pow(a, b);
}

int Input(string output)
{
   Console.Write(output);
   return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"number {A} to the power {B} = {square(A, B)}");





