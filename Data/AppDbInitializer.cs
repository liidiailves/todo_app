using Todo_app.Data;

public class AppDbInitializer
{
    public static void Seed(AppDbContext context)
    {
        context.Database.EnsureCreated();

        // TodoItems
        if (!context.TodoItems.Any())
        {
            context.TodoItems.AddRange(new List<TodoItem>()
                {
                    new TodoItem()
                    {
                        Description = "Täida ülesanne 1",
                        ItemDueDate = DateTime.Now.AddHours(2),
                    },
                    new TodoItem()
                    {
                        Description = "Täida ülesanne 2",
                        ItemDueDate = DateTime.Now.AddMinutes(4),
                    },
                    new TodoItem()
                    {
                        Description = "Täida ülesanne 3",
                        ItemDueDate = DateTime.Now.AddDays(3).AddHours(1),
                    },
                    new TodoItem()
                    {
                        Description = "Täida ülesanne 4",
                        ItemDueDate = DateTime.Now.AddDays(1).AddHours(1),
                    }
                });

            context.SaveChanges();
        }
    }
}

