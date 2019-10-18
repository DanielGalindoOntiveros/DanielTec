using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Tarea
    {

        public class TaskItem
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }

            public TaskItem() { }

            public TaskItem(string title, string desc)
            {
                Title = title;
                Description = desc;
                IsCompleted = false;
            }

           
            public TaskItem(int number, string title, string desc)
            {
                Number = number;
                Title = title;
                Description = desc;
                IsCompleted = false;
            }

           
        }

        public class TaskList : List<TaskItem>
        {
            public TaskList()
            {
            }

            public void Add(string name, string title, string desc)
            {
                int numberOfTasks = this.Count();
                int number = numberOfTasks++;

                this.Add(new TaskItem( number, name, title, desc));
            }

            public void DisplayList()
            {
                //Console.CLear();
                //Console.WriteLine("\t Task List");
                Console.WriteLine();
                Console.WriteLine("Num |  Name |  Title  | Description");
                Console.WriteLine("---------------------------");
                foreach (var t in this)
                {
                    Console.WriteLine("{0}     {1}\t{2}\t{3}", t.Number.ToString(),
                                                         t.Name,
                                                         t.Title,
                                                         t.Description);
                    Console.ReadKey();
                }
            }

            public void NewTaskItem()
            {
                string name = String.Empty;
                string title = String.Empty;
                string desc = String.Empty;

                Console.Write("Enter new task Title: ");
                name = Console.ReadLine().Trim();
                Console.WriteLine("{0}\n", name);

                Console.Write("Enter new task Title: ");
                title = Console.ReadLine().Trim();
                Console.WriteLine("{0}\n", title);

                Console.Write("Enter new task Description: ");
                desc = Console.ReadLine();
                Console.WriteLine("\"{0}\"", desc);

                this.Add(name, title, desc);
                Console.ReadKey();
            }
        }
    }

}
