using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList2
{
    class ListOfTask
    {
       public class TaskList : List<RepoTask>
        {
            public TaskList()
            {

            }

            public void Add(string na,string t,string d)
            {
                int Cantidad = this.Count();
                int num = Cantidad++;

                this.Add(new RepoTask(num,na,t,d));
                
            }

            public void ListOfTask()
            {
                Console.WriteLine();
                Console.WriteLine("Num  | Name  | Title  | Description");
                Console.WriteLine("-----------------------------");
                foreach (var u in this)
                {
                    Console.WriteLine("{0}     {1}\t{2}\t{3}", u.Id.ToString(),
                                                        u.Name,
                                                        u.Title,
                                                        u.Description);
                    Console.ReadKey();
                }
            }
            public void NewTask()
            {
                string n = String.Empty;
                string na = String.Empty;
                string t = String.Empty;
                string d = String.Empty;

                Console.Write("Enter new name: ");
                na = Console.ReadLine().Trim();
                Console.WriteLine("{0}\n", na);

                Console.Write("Enter new task Title: ");
                t= Console.ReadLine().Trim();
                Console.WriteLine("{0}\n", t);

                Console.Write("Enter new task Description: ");
                d = Console.ReadLine();
                Console.WriteLine("\"{0}\"", d);

                this.Add(na, t, d);
                Console.ReadKey();
            }
        }
    }
}
