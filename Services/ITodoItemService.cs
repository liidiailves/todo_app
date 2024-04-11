using Todo_app.Data;

namespace Todo_app.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem> GetById(int id);
        //Task<List<TodoItem>> GetAllAsync();

        Task<List<TodoItem>> GetAllSortedByDueDateDescending();
        Task<List<TodoItem>> GetItemsWithDeadlineWithin5Minutes();

        Task Save(TodoItem item);
        Task Delete(int id);
    }
}
