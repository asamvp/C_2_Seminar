/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int inputInt(string Msg)
{
    Console.WriteLine(Msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = inputInt("Введите число");

if (a > 99)
{
    while (a>999) {
        a=a/10;
    }
    int result = a % 10;
    Console.WriteLine($"Третья цифра равна {result}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
