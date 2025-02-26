using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoManager.Services;
using ToDoManager.Entities;
using ToDoManager.API.DTO;


namespace ToDoManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController(ToDoService toDoService) : ControllerBase
    {
        #region Azure Data Studio - SQL
        /*
            CREATE DATABASE [todoManager.db]
            GO
            USE [todoManager.db]
            CREATE TABLE Todos (
                Id INT PRIMARY KEY IDENTITY,
                Name VARCHAR(50) NOT NULL,
                [Description] VARCHAR(MAX) NOT NULL,
                [Date] DATE NOT NULL
            )
         */ 
        #endregion

        // http://.../api/todo
        [HttpGet]
        public IActionResult ReadToDos()
        {
            ToDoService ts = new();
            List<ToDo> list = ts.GetToDos();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult CreateToDo(CreateTodoDTO dto)
        {
            ToDoService ts = new();
            ts.Add(new ToDo
            {
                Name = dto.Name,
                Description = dto.Description,
            }, dto.NbDays);

            return Created();
        }
    }
}
