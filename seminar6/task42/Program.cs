// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Vvod(string msg)
{
  Console.WriteLine(msg);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void Conv (int num)
{
  int num1 = 0;
  string s = "";
    while (num > 0)
  {
    num1 = num%2;
    num = num/2;
    s = num1 + s;
  }
   Console.WriteLine(s);
}

int number = Vvod("Введите число: ");
Conv(number);
