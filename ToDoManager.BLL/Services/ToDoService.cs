//using Microsoft.EntityFrameworkCore;
//using ToDoManager.BLL.Entities;

//namespace ToDoManager.BLL.Services
//{
//    public class ToDoService
//    {
//        // va bientôt être retirée pour mettre une db plus tard
//        // si private, pas besoin de { get; set;}
//        // private List<ToDo> ToDoList = [];
//        // public List<ToDo> ToDoList { get; set; } = [];

//        ToDoContext context = new( new DbContextOptionsBuilder()
//            .UseSqlServer("server=DESKTOP-E563U3H;database=todoManager.db;integrated security=true;trustServerCertificate=true")
//            .Options
//            );

//        public void Add(ToDo toDo, int nbOfDays)
//        {
//            // set la date de la todo
//            toDo.Date = DateTime.Now.AddDays(nbOfDays);
//            context.Todos.Add(toDo);
//        }

//        public List<ToDo> GetToDos()
//        {
//            // équivalent : return ToDoList.Where(t => t.Date > DateTime.Now).OrderBy(t => t.Date).ToList();
//            // renvoie une nouvelle liste
//            return [..context.Todos
//                .Where(t => t.Date > DateTime.Now)
//                .OrderBy(t => t.Date)
//                ];
//        }
//    }
//}
