using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task Do = new Task();

            var taskList = new Task.TaskList();


            taskList.NewTaskItem();
            taskList.DisplayList();
        }
    }
}
