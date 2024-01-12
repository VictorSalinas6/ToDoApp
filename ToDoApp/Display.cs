using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class Display
    {
        public static void displayTasks()
        {

            var text1 = "TO-DO LIST";
            Menus.CenterText(text1);
            Console.WriteLine("Tasks");
            Console.WriteLine();

            foreach (var toDo in ListOfToDos.ToDos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{toDo.Name.PadRight(31)}");
                Console.Write("Status: ");
                displayCheckmark(toDo.Finished);
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine($"{toDo.Description}");

                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to return to Menu");
            Console.ReadLine();
            Console.Clear();
        }

        public static IToDo displayforUpdateTask()
        {

            var text1 = "TO-DO LIST";
            Menus.CenterText(text1);
            Console.WriteLine("Id\tName");

            foreach (var toDo in ListOfToDos.ToDos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{toDo.Id}\t");
                Console.BackgroundColor = default;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{toDo.Name.PadRight(31)}");
                Console.Write("Status: ");
                displayCheckmark(toDo.Finished);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine();
            Console.WriteLine("Please select the Id of the To-Do you wish to change.");
            Console.WriteLine("Type \"Cancel\" if you wish to cancel this operation");
            var choice = UserInput.CheckInList();
            Console.Clear();

            return ListOfToDos.ToDos[choice];
        }

        public static IToDo displayforDeleteToDo()
        {

            var text1 = "TO-DO LIST";
            Menus.CenterText(text1);
            Console.WriteLine("Id\tName");

            foreach (var toDo in ListOfToDos.ToDos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{toDo.Id}\t");
                Console.BackgroundColor = default;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{toDo.Name.PadRight(31)}");
                Console.Write("Status: ");
                displayCheckmark(toDo.Finished);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine();
            Console.WriteLine("Please select the Id of the To-Do you wish to delete.");
            Console.WriteLine("Type \"Cancel\" if you wish to cancel this operation");
            var choice = UserInput.CheckInList();
            Console.Clear();

            return ListOfToDos.ToDos[choice];
        }

        public static IToDo displayforUpdateStatus()
        {

            var text1 = "TO-DO LIST";
            Menus.CenterText(text1);
            Console.WriteLine("Id\tName");

            foreach (var toDo in ListOfToDos.ToDos)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{toDo.Id}\t");
                Console.BackgroundColor = default;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{toDo.Name.PadRight(31)}");
                Console.Write("Status: ");
                displayCheckmark(toDo.Finished);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine();
            Console.WriteLine("Please select the Id of the To-Do yo wish to change the status.");
            Console.WriteLine("Type \"Cancel\" if you wish to cancel this operation");
            var choice = UserInput.CheckInList();
            Console.Clear();

            return ListOfToDos.ToDos[choice];
        }
        public static void displayCheckmark(bool check)
        {
            if (check)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine('\u2713');
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine('X');
            }

            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
