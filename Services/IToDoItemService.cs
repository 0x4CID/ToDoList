using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public interface IToDoItemService
    {
        Task<ToDoItem[]> GetUnfinishedItems();
    }
}