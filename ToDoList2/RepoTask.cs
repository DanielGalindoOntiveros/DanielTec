using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList2
{
    class RepoTask : Task
    {
        private string d1;
        public RepoTask() { }

        public RepoTask(string t, string d)
        {
            Title = t;
            Description = d;
            IsCompleted = false;
        }

        public RepoTask(int num, string t, string d)
        {
            Id = num;
            Title = t;
            Description = d;
            IsCompleted = false;            
        }

        public RepoTask(int num, string t, string d, string d1): this(num, t, d)
        {
            this.d1 = d1;
        }
    }
}
