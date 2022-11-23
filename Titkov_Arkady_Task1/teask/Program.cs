

int[] triangl = new int[3];

int[]  Getsizes(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {System.Console.WriteLine($"Введите {i+1}");
    triangl[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
void Proverka(int[] array)
{
    int max = array[0];
    int j = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (max < array[i]) 
        {
            j=i;
            max=array[i];
        }
    }
    int sum = 0;
    foreach (int item in array )
    {
        if(item != max) sum=sum + item;
    }
    if (sum > max) System.Console.WriteLine("Треугольник возможен");
    else System.Console.WriteLine("Треугольник не возможен");
}
Getsizes(triangl);
Proverka(triangl);
int chislo;
Console.ReadLine();