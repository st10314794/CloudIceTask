using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoListTwo.Models;

namespace ToDoListTwo.Data
{
    public class ToDoListTwoContext : DbContext
    {
        public ToDoListTwoContext (DbContextOptions<ToDoListTwoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoListTwo.Models.Task> Task { get; set; } = default!;
    }
}
