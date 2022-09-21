using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class FakeToDoItemService : IToDoItemService
    {
        public Task<ToDoItem[]> GetUnfinishedItems()
        {
            var item1 = new ToDoItem
            {
                Title = "Learn more .Net",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new ToDoItem
            {
                Title = "Make better apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new[] {item1, item2});
        }
    }
}