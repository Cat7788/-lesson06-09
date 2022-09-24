//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*int FuncCountPositive( int nums)
{
    int count = 0;
    for (int i = 1; i <= nums; i++)
    {
      Console.Write($"Введите числo {i}: ");
      int num = Convert.ToInt32(Console.ReadLine());
      if (num > 0) count++;
   }
   return count;
}

Console.WriteLine("Введите количество чисел: ");
int nums = Convert.ToInt32(Console.ReadLine());
while (nums < 1)
{
    Console.WriteLine("Число должно быть больше нуля. Введите количество чисел: ");
    nums = Convert.ToInt32(Console.ReadLine());
}
int count = FuncCountPositive(nums);
Console.WriteLine($"Количество чисел больше нуля равно {count}");*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/*double FuncX(double b1, double b2, double k1, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}
Console.WriteLine("Уравнение вида  y = k1 * x + b1. Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Уравнение вида  y = k1 * x + b1. Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Уравнение вида  y = k2 * x + b2. Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Уравнение вида  y = k2 * x + b2. Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 & b1 == b2) Console.WriteLine("Оба уравнения описывают одну прямую, следовательно, имеется бесконечное множество точек пересечения.");
else if (k1 == k2) Console.WriteLine("Прямые параллельны, следовательно,не имеют точек пересечения.");
else
{
    double x = FuncX(b1, b2, k1, k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых y = {k1}*x + {b1} и y = {k2}*x + {b2} это ({x}; {y})");
}*/