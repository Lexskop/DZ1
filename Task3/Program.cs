/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Приветствую Вас! Эта программа подскажет, является ли введенное число чётным или нечётным.");
int userChoice = 1;
while (userChoice == 1)
{
Console.WriteLine("Введите целое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 % 2 == 0)
{
    Console.WriteLine("Ваше число - чётное");
}
if (userNumber1 % 2 == 1)
{
    Console.WriteLine("Ваше число - нечётное");
}
if (userNumber1 % 2 == -1)
{
    Console.WriteLine("Ваше число - нечётное");
}

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
    Console.WriteLine("Надежно как Швейцарские часы!");
}
Console.WriteLine("Проверим другое число? 1 - Да, 0 - Нет");
userChoice = Convert.ToInt32(Console.ReadLine());
}