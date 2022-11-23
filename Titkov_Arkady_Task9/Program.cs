
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
System.Console.WriteLine("Задача 64: Задайте значение N. Вывести все натуральные числа в промежутке от N до 1. \n Выполнить с помощью рекурсии.");
System.Console.Write("Введите число для формирования последовательности N = ");

int N = int.Parse(Console.ReadLine());

void PrintNumbers(int N)
{
    
    if (N == 1) 
    {
         Console.Write($" {N} ");
        return;
    }
    else 
    {
        System.Console.Write($" {N} ");
        PrintNumbers(N-1);
        return;
    }
}
System.Console.Write($"N = {N} --> ");
PrintNumbers(N);
System.Console.WriteLine();
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();

System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
System.Console.Write("Введите число для формирования последовательности N = ");
N = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите число для формирования последовательности M = ");
int M = int.Parse(Console.ReadLine());

int SummaNumbers(int N, int M)
{
    if (N == M) 
    {
        return N;
    }
    else 
    {
       return M +=SummaNumbers(N,M-1);        
    }
}

System.Console.Write($"--> ");
System.Console.WriteLine(SummaNumbers(N,M));    
System.Console.WriteLine();
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();

System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. \nДаны два неотрицательных числа m и n.");
System.Console.Write("Введите число для формирования последовательности N = ");
N = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите число для формирования последовательности M = ");
M = int.Parse(Console.ReadLine());
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

System.Console.WriteLine($"Функция Аккермана(n({N}),m({M})) - {Akkerman(N,M)}");
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();
