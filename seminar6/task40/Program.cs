// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
// двух других сторон.

int Vvod(string msg)
{
  Console.WriteLine(msg);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

bool Rectangle(int a, int b, int c)
{
  bool res = false;
  if (a < b + c & b < a + c & c < a + b)
  res = true;
  return res;
}

int a = Vvod("Введите длину первой стороны треугольника: ");
int b = Vvod("Введите длину второй стороны треугольника: ");
int c = Vvod("Введите длину третьей стороны треугольника: ");

Console.WriteLine(Rectangle(a,b,c));
