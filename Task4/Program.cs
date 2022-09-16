/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Приветствую Вас! Эта программа покажет все чётные числа от 1 до Вашего числа");
int userChoice = 1;
while (userChoice == 1)
{
    Console.WriteLine("Введите число: ");
    int userNumber1 = Convert.ToInt32(Console.ReadLine());
    int count = 2;
    int print = 0;
    Console.Write($"Ваше число: {userNumber1} -> ");
    while (count <= userNumber1)
        {
            if ((count+1) < userNumber1)
            {
                Console.Write($"{print = print + 2}, ");
                count += 2;
            }
            else
            {
                Console.Write($"{print = print + 2}");
                count += 2;
            }
        }

    Console.WriteLine("");
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