//Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int number = new Random().Next(100,999);
Console.WriteLine($"Рандом число = {number}");
int result_left= number/100*10;
int result_right= number%10;
int result = result_left+result_right;
Console.WriteLine($"Результат = {result}");