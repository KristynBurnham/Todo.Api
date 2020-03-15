namespace Todo.Api.Models
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string Action { get; set; }
        public bool IsDone { get; set; }
    }
}