/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
 int NumInt (string mess, string error = "Вы ввели не корректное значение!")   
  {
    int num;
    if (!int.TryParse(mess, out num))  
      {
        Console.WriteLine(error);
      }
    return num;
  }

Console.WriteLine("Ввеите несколько целых чисел, для окончания ввода нажмите \"q\": ");
int k=0;
while(true)
  {
    string mes=Console.ReadLine();
    if (mes=="q"){break;}
    else
      {
        int num = NumInt(mes);
        if (num>0) {k++;}
      }
  }
Console.Write("Коичество введенных числе больше 0 равно {0}", k);