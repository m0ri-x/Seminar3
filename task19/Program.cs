// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 & number < 99999)
    {
        int first = number.ToString()[0] - '0';
        int second = number.ToString()[1] - '0';
        int third = number.ToString()[2] - '0';
        int fourth = number.ToString()[3] - '0';
        int fifth = number.ToString()[4] - '0';
    if (first == fifth && second == fourth)
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");
    }

else 
    {
        Console.WriteLine("Введено неверное число");
    }