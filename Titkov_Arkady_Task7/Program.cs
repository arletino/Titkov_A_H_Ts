// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                     array[i, j] = rnd.Next(-10, 10);
                           
                }
        }
    return array;
}
void PrintIntArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write("{0,6:F0}", array[i, j]);          
        }
      Console.WriteLine(); 
    }   
}

void PrintDoubleArray(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write("{0,6:F1}", array[i, j]);          
        }
      Console.WriteLine(); 
    }   
}

double[,] GetArrayDouble(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                     array[i, j] = rnd.NextDouble()*rnd.Next(-50, 50);
                           
                }
        }
    return array;
}
Console.Clear();
string numbers = String.Empty; 
System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
System.Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол-во Строк: ");
int m = int.Parse(Console.ReadLine());
PrintDoubleArray(GetArrayDouble(m,n));
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();

System.Console.WriteLine("Задача 50. Принимает позиции элемента в двумерном массиве, \n и возвращает значение этого элемента или же указание, что такого элемента нет.");
System.Console.WriteLine("Введите целые числа через запятую");
string date = Console.ReadLine();

string[] NumbersSpliter(string str, string spliter)
{
    return str.Split(new [] { spliter } ,StringSplitOptions.RemoveEmptyEntries);
}

string[] strNumbers = NumbersSpliter(date, ",");

bool ElementInArray(string[] pozArray, int[,] array)
{
    bool flag = true; 
    int number = 0;
    int[] Poz = new int[2];   
    for (int i = 0; i < pozArray.GetLength(0); i++)
    {
        if (int.TryParse(pozArray[i], out number) && number <= array.GetLength(i) ) 
        {
        Poz[i] = number;
        System.Console.WriteLine(Poz[i]);
        }
        else flag = false;
    }
    if (flag) System.Console.WriteLine($"Заправшиваемый элемент равен - {array[Poz[0],Poz[1]]}");
    else System.Console.WriteLine("Запрашиваемого элемента нет в массиве");
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return flag;
}
int[,] array = GetArray(5,5);
PrintIntArray(array);
bool Checking = ElementInArray(strNumbers, array);

System.Console.WriteLine("Задача 52.  Найдите среднее арифметическое элементов в каждом столбце.");
System.Console.WriteLine();

double[] MiddleArifColom(int[,] array)
{
    double[] MiddleArif = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
           MiddleArif[i] += array[j,i]; 
        }
        MiddleArif[i] /= array.GetLength(0);
        System.Console.Write("{0,6:F1}", "^");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        System.Console.Write("{0,6:F1}", MiddleArif[i]);
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return MiddleArif;
}
PrintIntArray(array);
System.Console.WriteLine();
double[] result = MiddleArifColom(array);

