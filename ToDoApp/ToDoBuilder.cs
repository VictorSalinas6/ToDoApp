using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class ToDoBuilder
    {
        public static IToDo toDoBuilder(IToDo task)
        {
            var text1 = "TO-DO CREATOR";
            Menus.CenterText(text1);
            Console.WriteLine();

            Console.WriteLine("Please enter the name of your To-Do.");
            task.Name = UserInput.ToDoInput();
            Console.WriteLine();

            Console.WriteLine("Please enter the description.");
            task.Description = UserInput.ToDoInputDescription();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            var text2 = "To-Do created!";
            Menus.CenterText(text2);
            Thread.Sleep(1000);
            Console.Clear();

            return task;
        }
    }
}
