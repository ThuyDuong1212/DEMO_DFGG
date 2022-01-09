using System;

namespace DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Store app = new Store();
            bool running = true;
            while (running)
            {
                app.GetName();
                app.GetSize();
                app.GetColor();

                System.Console.WriteLine("Change them:");
                System.Console.WriteLine("1. Winter");
                System.Console.WriteLine("2. Summer");
                System.Console.WriteLine("0.Exit");
                System.Console.Write("Your choice: ");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                    {
                        app.ChangeTheme("Winter");
                        break;
                    }
                    case 2: 
                    {
                        app.ChangeTheme("Summer");
                        break;
                    }
                    case 0: 
                    {
                        Console.WriteLine("Exit");
                        running = false;
                        break;
                    }
                    default: Console.WriteLine("Invalid choice"); break;

                }
                
            }
        }
    }
}
