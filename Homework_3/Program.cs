/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int inputInt(string Msg)
{
    Console.WriteLine(Msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = inputInt("Введите день недели");
if (a > 0 && a < 8)
{
    if (a == 6 || a==7)
    {
        Console.WriteLine("Выходной, можно отдыхать...");
    }
    else { Console.WriteLine("Иди на работу"); }
}
else
{
    Console.WriteLine("Такого дня нет");
}

