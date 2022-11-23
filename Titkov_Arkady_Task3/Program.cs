/*Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int i;

string CheckInputNumbers(int FirstBorder, int LastBorder)
{   
    
    string numbers = String.Empty;
    bool flag = false;
    do
        {
             System.Console.Write("Пожалуйста введите число из пяти цифр - ");
             if((int.TryParse(numbers = Console.ReadLine(), out i)) && i > FirstBorder && i < LastBorder) 
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
        return numbers;
}
/*bool CheckPolindrom(string numbers)
{
    for (int i = 0; i < numbers.Length/2; i++)
    {
        if (numbers[i] != numbers[numbers.Length-i-1]) 
        {
            
            return false; 
        }
    }
     return true;
}

if (CheckPolindrom(CheckInputNumbers())) System.Console.WriteLine(" Ваше число полиндром");
else System.Console.WriteLine("Ваше число не полиндром");
*/
/*
CheckInputNumbers(1,10);
void TableCubes(int number)
{
    for (int j = 1; j <= number; j++)
    System.Console.Write($"{Math.Pow(j,3)}, ");
}
TableCubes(i);*/
int[] A = new int[3];
int[] B = new int[3];
System.Console.WriteLine("Введите координаты точки через запятую");
string date = Console.ReadLine();
string [] pointA = date.Split(',');
System.Console.WriteLine("Введите координаты точки через запятую");
string date = Console.ReadLine();
string [] pointA = date.Split(',');
pointA.trim    
double DistansIn3D(int[] A, int[] B)
{
return Math.Sqrt(Math.Pow((A[0] - B[0]),2)+Math.Pow((A[1] - B[1]),2) + Math.Pow((A[2]- B[2]),2));

}
