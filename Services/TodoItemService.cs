using Microsoft.EntityFrameworkCore;
using Todo_app.Data;

namespace Todo_app.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly AppDbContext _context;

        public TodoItemService(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<TodoItem> GetById(int id)
        {
            var existingItem = _context.TodoItems.Local.FirstOrDefault(m => m.Id == id);
            if (existingItem != null)
            {
                _context.Entry(existingItem).State = EntityState.Detached;
            }

            return await _context.TodoItems.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Save(TodoItem item)
        {
            if (item.Id == 0)
            {
                await _context.AddAsync(item);
            }
            else
            {
                var existingItem = _context.TodoItems.Local.FirstOrDefault(m => m.Id == item.Id);
                if (existingItem != null)
                {
                    _context.Entry(existingItem).State = EntityState.Detached;
                }

                _context.Update(item);
            }

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var item = await GetById(id);
            if (item == null)
            {
                return;
            }

            _context.Remove(item);

            await _context.SaveChangesAsync();
        }

        //public async Task<List<TodoItem>> GetAllAsync()
        //{
        //    return await _context.TodoItems.ToListAsync();
        //}

        public async Task<List<TodoItem>> GetAllSortedByDueDateDescending()
        {
            return await _context.TodoItems.OrderByDescending(item => item.ItemDueDate).ToListAsync();
        }

        public async Task<List<TodoItem>> GetItemsWithDeadlineWithin5Minutes()
        {
            var currentDateTime = DateTime.Now;
            var fiveMinutesFromNow = currentDateTime.AddMinutes(5);
            return await _context.TodoItems
                .Where(item => item.ItemDueDate <= fiveMinutesFromNow)
                .ToListAsync();
        }
    }
}
