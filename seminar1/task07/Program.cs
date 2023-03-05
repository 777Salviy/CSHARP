//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//последнюю цифру этого числа.
//пример: 456 -> 6


// Console.Write("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine());
// int lastDigit = number % 10; 
// Console.WriteLine("Последняя цифра: " + lastDigit);
// Данный вариант не предполагает исключение введенея разнядности более 3.

// другой вариант

Console.WriteLine ("Введите трёхзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number > 99 && number < 1000)
{
    int lastnumber = number % 10;
    System.Console.WriteLine ("Последнее число: " + lastnumber);
}
else
{
    Console.WriteLine ("Неверное число");
}
