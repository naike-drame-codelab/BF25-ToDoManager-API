namespace ToDoManager.API.DTO
{
    public class CreateTodoDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int NbDays { get; set; }
    }
}
