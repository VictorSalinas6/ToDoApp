using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class Update
    {
        public static IToDo UpdateToDo(IToDo update)
        {

            var text2 = $"{update.Name}";
            Menus.CenterText(text2);
            Console.WriteLine();

            Console.WriteLine("Do you wish to update the name? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the new name of the To-Do");
                update.Name = UserInput.ToDoInput();
            }
            Console.WriteLine();

            Console.WriteLine("Do you wish to update the description? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the new last name");
                update.Description = UserInput.ToDoInput();
            }
            Console.WriteLine();

            Console.WriteLine();
            var text1 = "To-Do updated!";
            Menus.CenterText(text1);
            Thread.Sleep(1000);
            Console.Clear();

            return update;
        }

        public static IToDo UpdateStatus(IToDo update)
        {
            var text2 = $"{update.Name}";
            Menus.CenterText(text2);
            Console.WriteLine();

            Console.WriteLine($"Have you finished {update.Name}?");
            Console.WriteLine("([Y]es or [N]o)");
            update.Finished = UserInput.YesOrNoChecker();

            Console.WriteLine();

            Console.WriteLine();
            var text1 = "To-Do updated!";
            Menus.CenterText(text1);
            Thread.Sleep(1000);
            Console.Clear();

            return update;
        }
    }
}
