using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class Menus
    {
        public static void StartUp()
        {
            var text = "Welcome to your TO Do App!";
            CenterText(text);
            Console.WriteLine();
            Console.WriteLine("What would you like to do today?");
        }

        public static int Options()
        {
            Console.WriteLine("1. Create a new To-Do task");
            Console.WriteLine("2. Change the status of a To-Do");
            Console.WriteLine("3. Display all my pending To-Do's");
            Console.WriteLine("4. Update an existing To-Do");
            Console.WriteLine("5. Delete a To-Do");
            Console.WriteLine("6. End Application");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            var option = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            return UserInput.MenuInput(option);
        }

        public static void FirstCreate()
        {
            Console.WriteLine("Your To-Do's are empty!");
            Console.WriteLine("Please first create a new To-Do!");
            Console.WriteLine();
        }

        public static void CenterText(string text)
        {
            int consoleWidth = Console.WindowWidth;

            int padding = (consoleWidth - text.Length) / 2;

            Console.WriteLine(text.PadLeft(padding + text.Length));
        }

        public static void CreateToDo()
        {
            Console.Write($"Creating a new To-Do");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Clear();
        }

        public static void ReadingTasks()
        {
            Console.Write($"Reading your database");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Clear();
        }

        public static void Continue()
        {
            Console.WriteLine("Do you wish to do something else?");
        }

        public static void GoodBye()
        {
            string text = "Thank you for using our services. GoodBye!";
            CenterBothText(text);
            Thread.Sleep(1000);

            Environment.Exit(0);
        }

        public static void CenterBothText(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            int horizontalPadding = (consoleWidth - text.Length - 6) / 2;
            int verticalPadding = (consoleHeight) / 4;

            Console.SetCursorPosition(horizontalPadding, verticalPadding);
            Console.WriteLine(text);
        }
    }
}
