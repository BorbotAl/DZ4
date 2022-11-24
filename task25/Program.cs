// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16


Console.WriteLine("Возведём число А в натуральную степень В");
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В: ");
int b = Convert.ToInt32(Console.ReadLine());

int PowerAtoB(int num1, int num2)
{
    int power = 1;
    for (int i = 1; i <= num2; i++)
    {
        power = power * num1;
    }
    return power;
}

if (b > 0)
{
    int result = PowerAtoB(a, b);
    Console.WriteLine($"Число {a} в степени {b} --> {result}");
}
else Console.WriteLine("Число В должно быть натуральным");