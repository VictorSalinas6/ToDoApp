using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public static class ToDosApp
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Menus.StartUp();
            var on = true;
            do
            {
                
                var option = Menus.Options();

                option = UserInput.CheckFirst(option);

                switch (option)
                {
                    case 1:
                        Menus.CreateToDo();
                        IToDo toDo = new ToDos();
                        toDo = ToDoBuilder.toDoBuilder(toDo);
                        ListOfToDos.ToDos.Add(toDo);
                        break;
                    case 2:
                        Menus.ReadingTasks();
                        var choiceStatus = Display.displayforUpdateTask();
                        choiceStatus = Update.UpdateStatus(choiceStatus);
                        break;
                    case 3:
                        Menus.ReadingTasks();
                        Display.displayTasks();
                        break;
                    case 4:
                        Menus.ReadingTasks();
                        var choiceUpdate = Display.displayforUpdateTask();
                        choiceUpdate = Update.UpdateToDo(choiceUpdate);
                        break;
                    case 5:
                        Menus.ReadingTasks();
                        var choiceDelete = Display.displayforDeleteToDo();
                        Delete.DeleteToDo(choiceDelete);
                        break;
                    case 6:
                        on = false;
                        break;
                    case 0:
                    default:
                        break;
                }
                if (option != 5 && option != 0)
                    Menus.Continue();
            } while (on);

            Console.Clear();
            Menus.GoodBye();
            
        }
    }
}
