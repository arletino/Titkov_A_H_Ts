
Console.Clear();
Exercise Task = new Exercise();
ArrayTasksFromFile Tasks = new ArrayTasksFromFile();
MainMenu Menu = new MainMenu();
ConsoleKeyInfo key;
int numberMenu =0;

do
    {
     
    
        Tasks.PrintTask();
        numberMenu = Menu.Menu(Tasks.PositionTasks());
        Console.SetCursorPosition(0, Tasks.Text().Length+1);
        System.Console.WriteLine(Tasks.ArrayTasks()[numberMenu]);
        bool flag =false;
        
            
            switch (numberMenu)
            {
                case 1:
                while (!flag)
                {
                    string numbers =String.Empty;
                    Console.SetCursorPosition(0,0);
                    Console.Clear();
                    System.Console.WriteLine(Tasks.ArrayTasks()[numberMenu]);
                    System.Console.Write("Пожалуйста введите трехзначное число - ");
                    do
                    {
                        
                        key = Console.ReadKey(true);
                        numbers.Append(key.KeyChar);
                        System.Console.Write(key.KeyChar);
                    } 
                    while(key.Key != ConsoleKey.Enter);
                    flag = Task.Ten(numbers);
                    Console.ReadLine();
                }
                    break;
                case 2:    
                    Console.SetCursorPosition(0,0);
                    Console.Clear();
                    System.Console.WriteLine(Tasks.ArrayTasks()[numberMenu]);
                    Task.Thirteen();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.SetCursorPosition(0,0);
                    Console.Clear();
                    System.Console.WriteLine(Tasks.ArrayTasks()[numberMenu]);
                    Task.Fithteen();
                    Console.ReadLine();
                    break;
            }
        }
    while(numberMenu !=-1);
    
                
