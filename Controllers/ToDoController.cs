using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _ToDoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _ToDoItemService = toDoItemService;
        }
        public async IActionResult Index()
        {
            var items = await _ToDoItemService.GetUnfinishedItems();
        }
    }
}