using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoListTwo.Data;
using System;
using System.Linq;

namespace ToDoListTwo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ToDoListTwoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ToDoListTwoContext>>()))
            {
                // Look for any movies.
                if (context.Task.Any())
                {
                    return;   // DB has been seeded
                }
                context.Task.AddRange(
                    new Task
                    {
                        Name = "Buy Dog",
                        DueDate = DateTime.Parse("2024-3-21"),
                        IsCompleted = true 
                    },
                    new Task
                    {
                        Name = "Consume an Unhealthy Amount of Bread",
                        DueDate = DateTime.Parse("2024-3-21"),
                        IsCompleted = true
                    },
                    new Task
                    {
                        Name = "Squat",
                        DueDate = DateTime.Parse("2024-3-21"),
                        IsCompleted = true
                    },
                    new Task
                    {
                        Name = "Have Existential Crisis",
                        DueDate = DateTime.Parse("2024-3-21"),
                        IsCompleted = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
