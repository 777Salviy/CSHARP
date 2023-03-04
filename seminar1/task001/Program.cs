// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя).
// Например:
// ● 4 -> 16
// ● -3 -> 9
// ● -7 -> 49

Console.WriteLine ("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine ());
int num = i*i;
Console.WriteLine (num);

if (num>9)
{
    Console.WriteLine("Число больше 9");
}
else
{
    Console.WriteLine("Число меньше 9");
}
if (num == 9)
{
    Console.WriteLine("Число равно 9");
}