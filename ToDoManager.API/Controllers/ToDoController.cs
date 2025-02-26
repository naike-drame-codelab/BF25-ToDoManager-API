using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoManager.BLL.Entities;
using ToDoManager.BLL.Services;

namespace ToDoManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ReadToDos()
        {
            ToDoService ts = new();
            List<ToDo> list = ts.GetToDos();
            return Ok(list);
        }

        //public IActionResult CreateToDo()
        //{

        //}
    }
}
