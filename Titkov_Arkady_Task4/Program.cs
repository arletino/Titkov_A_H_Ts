// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int CheckInputNumbers()
{   
    int i = 0;
    string numbers = String.Empty;
    bool flag = false;
    do
        {
             System.Console.Write("Пожалуйста введите число - ");
             if((int.TryParse(numbers = Console.ReadLine(), out  i)) ) 
                {
                    flag =false;
                    break;
                }
             else
             {
                Console.ForegroundColor =ConsoleColor.Red;
                Console.WriteLine("Вы ввели недопустимое значение повторите ввод");
                Thread.Sleep(1300);
                Console.Clear();
                Console.ResetColor();
                flag = true;
             } 
        } while (flag);
    return i;
}
int Powfunction(int number, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *=number;
    }
    System.Console.WriteLine($"Число {number} в степени {pow} = {result}");
    System.Console.WriteLine("Ожидайте");
    Thread.Sleep(2000);
    Console.Clear();
    return result;
}

Console.Clear();
System.Console.WriteLine("Задача №25 Возведение числа в степень равную второму числу");
Powfunction(CheckInputNumbers(),CheckInputNumbers());

System.Console.WriteLine("Задача №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");
string number = CheckInputNumbers().ToString();
int SumNumbers(string number)
{
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        result += int.Parse(number[i].ToString());
    }
    Console.WriteLine($"Сумма цифр числа {number}  = {result}");
    Console.WriteLine("Ожидайте");
    Thread.Sleep(3000);
    Console.Clear();
    return result;
}
SumNumbers(number);
System.Console.WriteLine("Задача №29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран");
int[] GetArray( int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i] = rnd.Next(1, 20);
            Console.Write($"{array[i]}, ");       
        }
    System.Console.WriteLine();
    Console.WriteLine("Ожидайте");
    Thread.Sleep(5000);
    Console.Clear();
    return array;
}
GetArray(8);