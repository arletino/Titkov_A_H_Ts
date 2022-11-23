public class MainMenu
{
    public int Menu(int[] array)
    {
        ConsoleKey key;
        int[] positionTask = array;
        int y = positionTask[0];
        int numberTask = 0;
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, y);
        Console.BackgroundColor = ConsoleColor.Green;
        string MenuWord = "Задача";
        System.Console.Write(MenuWord);
        Console.SetCursorPosition(0, y);

        while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter && key != ConsoleKey.Escape)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(0, y);
                    Console.ResetColor();
                    System.Console.Write(MenuWord);
                    Console.SetCursorPosition(0, y);
                    numberTask--;
                    if (y < positionTask.First()+1)
                        {
                            y = positionTask.Last();
                            numberTask = positionTask.Length-1;
                        }
                    else y = positionTask[numberTask];

                    Console.SetCursorPosition(0, y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    System.Console.Write(MenuWord);
                    Console.SetCursorPosition(0, y);
                    Console.ResetColor();
                    break;
                case ConsoleKey.DownArrow:
                    Console.SetCursorPosition(0, y);
                    Console.ResetColor();
                    System.Console.Write(MenuWord);
                    Console.SetCursorPosition(0, y);
                    numberTask++;
                    if (y > positionTask.Last()-1)
                        {
                            y = positionTask.First();
                        }
                    else y = positionTask[numberTask];
                    Console.SetCursorPosition(0, y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    System.Console.Write(MenuWord);
                    Console.SetCursorPosition(0, y);
                    Console.ResetColor();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();    
                    System.Console.WriteLine("Досвидания");
                    Console.ResetColor();
                    numberTask = -1;
                    break;
            }
        }

        Console.ResetColor();
        Console.CursorVisible = true;
    return numberTask;
    }    
}