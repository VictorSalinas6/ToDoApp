using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class ToDos : IToDo
    {
        public int Id { get; set; } = ListOfToDos.ToDos.Count + 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; } = false;
    }
}
