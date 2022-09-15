/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Приветствую Вас! Эта программа поможет сравнить два числа и покажет, какое из них больше.");
Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    Console.WriteLine($"a = {userNumber1}; b = {userNumber2} -> max = {userNumber1}; min = {userNumber2}");
}
else
{
    if (userNumber1 < userNumber2)
    {
       Console.WriteLine($"a = {userNumber1}; b = {userNumber2} -> max = {userNumber2}; min = {userNumber1}"); 
    }
    else
    {
        Console.WriteLine($"a = {userNumber1}; b = {userNumber2} -> a = b; Они равны");
    }
}