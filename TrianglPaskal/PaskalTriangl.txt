int[,] PaskalArray(int[,] arrayPaskal)
{
    for (int i = 0; i < arrayPaskal.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPaskal.GetLength(1); j++)
        {
            arrayPaskal[i,j] = 0;
        }
    }
    for (int i = 0; i < arrayPaskal.GetLength(0); i++)
    {
        arrayPaskal[i,0] = 1;
        arrayPaskal[i,i] = 1;
    }
    for (int i = 2; i < arrayPaskal.GetLength(0); i++)
    {
        for (int j = 1; j < i; j++)
        {
            arrayPaskal[i,j] = arrayPaskal[i-1,j-1]+arrayPaskal[i-1,j];
        }
    }
    return arrayPaskal;
}

void NiceViewArrayPaskal(int[,]array)
{
    string[] paskalText = new string [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string rowPaskal = string.Empty;
          
        for (int j = 0; j <= i; j++)
        {
           rowPaskal += $" {array[i,j]}";
        }
        paskalText[i] = rowPaskal; 

    } 
        for (int i = 0, j = 1; i < paskalText.Length; i++, j+=2) 
        {
            Console.SetCursorPosition((Console.WindowWidth - paskalText[i].Length) / 2
            , j);
            Console.WriteLine(paskalText[i]);
            System.Console.WriteLine(string.Empty);
        }
}

Console.Clear();
System.Console.Write("Введите количество строк для треугольника паскаль - ");
int m = int.Parse(Console.ReadLine());
int [,] arrayPaskal = new int[m,m];
Console.Clear();
NiceViewArrayPaskal(PaskalArray(arrayPaskal));