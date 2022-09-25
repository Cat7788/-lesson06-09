//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

/*void ShowNums(int n, int m)
{
    if (m != n)
        ShowNums(Math.Max(m, n) - 1, Math.Min(m, n));
    Console.Write($"{Math.Max(m, n)} ");
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ShowNums(num1, num2);
Console.WriteLine();*/

//------------------------------------------------------------------------

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*int SumOfDigits(int n, int m, int summ)
{
    if (m <= n)
    {
        summ += m;
        m++;
        summ = SumOfDigits(n, m, summ);
    }
    return summ;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
while (num1 == num2)
{
    Console.Write($"Второе число не может быть равным первому. Введите второе число: ");
    num2 = Convert.ToInt32(Console.ReadLine());
}
if (num2 > num1)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

int summ = SumOfDigits(num1, num2, 0);
Console.WriteLine($"Сумма натуральных элементов равна {summ}");*/

//-------------------------------------------------------------------------------------

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

/*void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m, n);
Console.WriteLine();*/



