/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();
 int NumInt (string mes= "Ведите целое число: ", string error = "Вы ввели не корректное значение!")   
  {
    Console.Write(mes);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))  
      {
        Console.WriteLine(error);
        Console.Write(mes);
      }
    return num;
  }

Console.WriteLine("Две прямые задаются уравнениями: y = k1 * x + b1, y = k2 * x + b2, введите кооэффициэнты k1, b1, k2, b2");
double k1= NumInt("Введите k1= ");
double b1= NumInt("Введите b1= ");
double k2= NumInt("Введите k2= ");
double b2= NumInt("Введите b2= ");
if (k1==k2){Console.Write("Прямые параллельны!");}
else
  {
    double x = (b1-b2)/(k2-k1);
    double y = k1*x+b1;
    Console.Write("Прямые пересекаются в точке с координатами ({0},{1})", x, y);
  }