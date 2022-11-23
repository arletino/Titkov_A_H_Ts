// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
System.Console.WriteLine("Задача №34 Напишите программу, которая покажет количество чётных чисел в массиве.");
int[] GetArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i] = rnd.Next(1, 10);
        }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        Console.Write($"{array[i].ToString("D2")} ");  
    }
    System.Console.WriteLine();   
}

int CheckInputNumbers()
{   
    int i = 0;
    string numbers = String.Empty;
    bool flag = false;
    do
        {
             System.Console.Write("Пожалуйста введите число элементов массива - ");
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
int[] array = GetArray(CheckInputNumbers());
PrintArray(array);
System.Console.WriteLine();
QuanEvenNumbers(array);
int QuanEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    System.Console.WriteLine($"Кол-во четных элементов - {count} ");
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return count;
}

System.Console.WriteLine("Задача №36 Найдите сумму элементов, стоящих на нечётных позициях.");
int GetSumNotEvenPositions(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 != 0)
            count += array[i];
    }
    System.Console.WriteLine($"Сумма элементов на нечетных позициях - {count} ");
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return count;
}
PrintArray(array);
GetSumNotEvenPositions(array);

System.Console.WriteLine("Задача №38 Найдите разницу между максимальным и минимальным элементов массива.");

int DevMinMaxElement(int[] array)
{
    int MinElement = array[0];
    int MaxElement = array[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (MinElement > array[i]) MinElement = array[i]; 
        if (MaxElement < array[i]) MaxElement = array[i];
    }
    System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {MaxElement - MinElement} ");
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return MaxElement - MinElement;
}
PrintArray(array);
DevMinMaxElement(array);
