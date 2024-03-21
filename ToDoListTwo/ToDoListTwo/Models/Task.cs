using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ToDoListTwo.Models
{
    public class Task
    {
        public int ID { get; set; }

        
        public required string Name { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }


    }
}
