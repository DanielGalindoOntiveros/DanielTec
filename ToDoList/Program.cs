using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {

            Tarea Do = new Tarea();

            var taskList = new Tarea.TaskList();

      
            taskList.NewTaskItem();
            taskList.DisplayList();
        }
    }
}
