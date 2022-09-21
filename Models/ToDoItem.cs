using System;
using System.ComponentModel.DataAnnotations;


namespace ToDoList.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }

        public bool IsComplete { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}