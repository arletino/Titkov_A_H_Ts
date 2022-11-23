// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
System.Console.WriteLine($"Задача 62. Напишите программу, которая заполнит спирально массив");


int[,] GetSpiralArray(int m, int n)
{
    Console.Clear();
    int temp = 0;
    int[,] array = new int[m,n];
    int j = 0;
    int i = 0;
    int k = 0;
    int x = m;
    int y = n;
    int l = 0;
    Console.SetCursorPosition(j*4,i*2);
    System.Console.Write($"{array[i,j].ToString("D2")} ");

    while(temp < m*n - 1)
    {
        if(j < y-1 && i == k) 
            {
                j++;
                temp +=1;
                array[i,j] = temp;
                Console.SetCursorPosition(j*4,i*2);
                System.Console.Write($"{array[i,j].ToString("D2")} ");
            }
        if (j == y-1 && i < x-1)
            {
                i++;
                temp +=1;
                array[i,j] = temp;
                Console.SetCursorPosition(j*4,i*2);
                System.Console.Write($"{array[i,j].ToString("D2")} ");
            }
        if (j == y && i < x && x > y)
            {
                i++;
                temp +=1;
                array[i,j] = temp;
                Console.SetCursorPosition(j*4,i*2);
                System.Console.Write($"{array[i,j].ToString("D2")} ");
            }
        if (i == x-1 && j > l-1 && x-1 !=k)
        {
            j--;
            temp +=1;
            array[i,j] = temp;
            Console.SetCursorPosition(j*4,i*2);
            System.Console.Write($"{array[i,j].ToString("D2")} ");
        }
        if (i > k+1 && j == l)
        {
            i--;
            temp +=1;
            array[i,j] = temp;
            Console.SetCursorPosition(j*4,i*2);
            System.Console.Write($"{array[i,j].ToString("D2")} ");
        }
        if (i-1 == k && j ==l)
           {
            k++;
            y--;
            x--;
            l++;
           }    
            Thread.Sleep(200);
        }
    Console.SetCursorPosition(0,array.GetLength(0)*2+1);  
    return array;
}
Console.Clear();
System.Console.WriteLine($"Задача 62. Напишите программу, которая заполнит спирально массив");
System.Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол-во Строк: ");
int m = int.Parse(Console.ReadLine());
GetSpiralArray(m,n);
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();


void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j].ToString("D2")} ");
        }
       Console.WriteLine();
    }   
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)*/
// /*

bool chekElement(int[,,] array, int element)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                        {
                           if (element == array[j, k ,i]) flag = true;  
                        }
                }
        }
    return flag;
} 

int[,,] GetUnicArray(int m, int n, int l)

{
    int[,,] array = new int[m, n, l];
    Random rnd = new Random();
    int element = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                        {
                           do
                           {
                                element = rnd.Next(1, 10*m*n*l);
                           }
                           while(chekElement(array, element));
                           array[j, k, i] = element; 
                        }
                }
        }
    return array;
}

void PrintArrayPos(int[,,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
                {
                 Console.Write($"{array[j, k, i].ToString("D3")} ({j},{k},{i}) ");          
                }
        Console.WriteLine();
        }
      Console.WriteLine(); 
    }   
}

Console.Clear();
System.Console.WriteLine($"Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. \n Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента");
System.Console.Write("Введите кол-во столбцов: ");
int row = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол-во Строк: ");
int col = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол-во таблиц: ");
int tab = int.Parse(Console.ReadLine());
PrintArrayPos(GetUnicArray(row,col,tab));
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                     array[i, j] = rnd.Next(1, 4);
                           
                }
        }
    return array;
}
/*
void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write($"{array[i, j].ToString("D2")} ");          
        }
      Console.WriteLine(); 
    }   
}
*/

System.Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

System.Console.Write("Введите кол-во столбцов матрицы А: ");
row = int.Parse(Console.ReadLine());
System.Console.Write("Введите кол-во Строк матрицы А: ");
col = int.Parse(Console.ReadLine());
int[,] arrayA = GetArray(row,col);
PrintArray(arrayA);
System.Console.WriteLine();
System.Console.Write("Кол-во строк матрицы В должно равнятся кол-ву столбцов матрицы А \n Введите кол-во столбцов матрицы B: ");
int colB = int.Parse(Console.ReadLine());
int[,] arrayB = GetArray(col,colB);
PrintArray(arrayB);
System.Console.WriteLine();


int[,] ArrayMulti(int[,]arrayA, int[,] arrayB)
{
 int[,] MultiArray = new int[arrayA.GetLength(0),arrayB.GetLength(1)];

 for (int k = 0; k < arrayA.GetLength(0); k++)
 {
    for (int i = 0; i < arrayB.GetLength(1); i++)
    {
        for (int j = 0; j < arrayB.GetLength(0); j++)
            {
                MultiArray[k,i] += arrayA[k,j]*arrayB[j,i];
                System.Console.Write($"{arrayA[k,j]}*{arrayB[j,i]} ");

                if (j < arrayB.GetLength(0) - 1) 
                    {
                        System.Console.Write("+");
                    }
                else
                    {
                    System.Console.WriteLine($" = {MultiArray[k,i]}");
                    }
            }
    }
 }
 System.Console.WriteLine();
return MultiArray;
}

PrintArray(ArrayMulti(arrayA,arrayB));

System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

System.Console.WriteLine($"адача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

System.Console.Write("Введите кол-во столбцов матрицы: ");
col= int.Parse(Console.ReadLine());
System.Console.Write("Введите кол-во Строк матрицы: ");
row = int.Parse(Console.ReadLine());
int[,] arrayminrow = GetArray(row,col);

int MinSummRowEl(int[,]array)
{
    int[] SummaElements = new int[array.GetLength(0)];
    

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    SummaElements[i] += array[i,j];
                    Console.Write($"{array[i, j].ToString("D2")} ");
                           
                } 
            Console.WriteLine($"  --> {SummaElements[i]}");
        }
    int minSumma = SummaElements[0];
    int indxMinSumma = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minSumma > SummaElements[i]) 
        {
            minSumma = SummaElements[i];
            indxMinSumma = i;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Номер строки с минимальной суммой --> {indxMinSumma} ");

    return indxMinSumma;
}
int indxMinSumma = MinSummRowEl(arrayminrow);
System.Console.WriteLine("Нажмите Enter для продолжения");
Console.ReadLine();
Console.Clear();
