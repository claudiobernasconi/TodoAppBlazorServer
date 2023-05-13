namespace TodoAppBlazorServer.Services;

public interface ITodoService
{
    public void Add(TodoItem item);
    public IEnumerable<TodoItem> GetAll();
    public void Delete(TodoItem item);
}