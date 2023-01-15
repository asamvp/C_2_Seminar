/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
int inputInt(string Msg)
{
    Console.WriteLine(Msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = inputInt("Введите первое число");
int b = inputInt("Введите второе число");
if (a % b == 0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");
}
else
{
    Console.WriteLine($"Число {a} не кратно числу {b} остаток {a % b}");
}