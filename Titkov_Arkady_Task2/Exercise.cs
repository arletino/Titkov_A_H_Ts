public class Exercise
{
    public bool Ten(string numbers)
    {
            
            int i;
            
            int numberDigitOutput = 1;
            
             if(int.TryParse(numbers, out i)&& i > 99 && i < 1000)
             {
                System.Console.WriteLine($"Вторая цифра вашего числа - {numbers[numberDigitOutput]}");
                return true;
             }
             else
             {
                Console.ForegroundColor =ConsoleColor.Red;
                Console.WriteLine("Вы ввели недопустимое значение повторите ввод");
                Thread.Sleep(1300);
                Console.Clear();
                Console.ResetColor();
               return false;
             } 
         
             
    }
    public void Thirteen()
    {
            int i;
            string numbers = String.Empty;
            while (true)
            {
             System.Console.Write("Пожалуйста введите число - ");
             if(int.TryParse(Console.ReadLine(), out i)) break;
             else
             {
                Console.ForegroundColor =ConsoleColor.Red;
                Console.WriteLine("Вы ввели недопустимое значение повторите ввод");
                Thread.Sleep(1300);
                Console.Clear();
                Console.ResetColor();
             } 
            }
        if (numbers.Length < 2) System.Console.WriteLine($"Ввашем числе нет третей цифры");
        else System.Console.WriteLine($"Третия цифра в вашем числе - {numbers[2]}");
              
    }
    
 
    public void Fithteen()
    {
        string [] arrayDaysInWeek = {"Monday","Thusday","Wensday","Thirstday","Friday", "Saturday","Sunday"};
        int i;
        while (true)
            {
             
             System.Console.Write("Пожалуйста введите номер дня недели, чтобы узнать является ли это день выходным - ");
             if(int.TryParse(Console.ReadLine(), out i) && i < 8 && i >0) break;
             else
             {
                Console.ForegroundColor =ConsoleColor.Red;
                Console.WriteLine("Вы ввели недопустимое значение повторите ввод");
                Thread.Sleep(1300);
                Console.Clear();
                Console.ResetColor();
             } 
            }
            if (i > 4) System.Console.WriteLine($"{arrayDaysInWeek[i-1]} - Выходной");
            else System.Console.WriteLine($"{arrayDaysInWeek[i-1]} - Не выходной");
    }
}
