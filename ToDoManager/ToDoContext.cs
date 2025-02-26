using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoManager.Entities;

namespace ToDoManager
{
    // represent my batabase
    // options => define where is my database and what kind of database i use
    public class ToDoContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ToDo> Todos { get; set; }


    }
}
