/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Приветствую Вас! Эта программа поможет сравнить три числа и покажет в результате максимальное из этих чисел.");
Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = userNumber1;

if (userNumber1 < userNumber2)
    {
        max = userNumber2;
    }
if (max < userNumber3)
{
    max = userNumber3;
}

Console.WriteLine($"a = {userNumber1}; b = {userNumber2}; c = {userNumber3} -> max = {max}");

Random rnd = new Random();
int value = rnd.Next(0, 4);
if (value == 0)
{
    Console.WriteLine("Отличный результат!");
}
if (value == 1)
{
    Console.WriteLine("Это было не так уж и сложно!");
}
if (value == 2)
{
    Console.WriteLine("Мы справились!");
}
if (value == 3)
{
    Console.WriteLine("Проверь меня еще раз :)");
}
Console.WriteLine($"{value}");