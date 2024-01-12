using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class Delete
    {
        public static void DeleteToDo(IToDo choice)
        {
            var text2 = $"{choice.Name}";
            Menus.CenterText(text2);
            Console.WriteLine();

            Console.WriteLine("Are you sure that you want to delete this To-Do? ([Y]es or [N]o)");

            if (UserInput.YesOrNoChecker())
            {
                ListOfToDos.ToDos.Remove(choice);

                Console.WriteLine();
                var text1 = "To-Do deleted!";
                Menus.CenterText(text1);
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
                Console.Clear();
        }
    }
}
