/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int inputInt(string Msg)
{
    Console.WriteLine(Msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = inputInt("Введите 3х значное число");
if (a > 99 && a < 1000)
{
    int result = a / 10;
    result = result % 10;
    Console.WriteLine($"Вторая цифра числа {a} равна {result}");
}
else
{
    Console.WriteLine($"Число {a} не трехзначное");
}
