using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager.BLL.Entities
{
    public class ToDo
    {
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Description { get; set; } = null!;

        public ToDo(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
