using Microsoft.AspNetCore.Mvc;
using Todo_app.Data;
using Todo_app.Services;

namespace Todo_app.Controllers
{
    public class TodoItemsController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemsController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var sortedTodoItems = await _todoItemService.GetAllSortedByDueDateDescending();
            return View(sortedTodoItems);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoItem = await _todoItemService.GetById(id.Value);
            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,ItemDate,ItemDueDate")] TodoItem todoItem)
        {
            if (ModelState.IsValid)
            {
                if (todoItem.ItemDueDate < DateTime.Now)
                {
                    ModelState.AddModelError("ItemDueDate", "Lahendamise tähtaeg peab olema tulevikus");
                    return View(todoItem);
                }

                todoItem.ItemDate = DateTime.Now;
                await _todoItemService.Save(todoItem);
                return RedirectToAction(nameof(Index));
            }

            return View(todoItem);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoItem = await _todoItemService.GetById(id.Value);
            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return NotFound();
            }

            var todoItemInDb = await _todoItemService.GetById(id);
            todoItemInDb.Description = todoItem.Description;

            if (todoItem.ItemDueDate < DateTime.Now)
            {
                ModelState.AddModelError("ItemDueDate", "Lahendamise tähtaeg peab olema tulevikus");
                return View(todoItem);
            }

            if (todoItemInDb.ItemDueDate != todoItem.ItemDueDate)
            {
                todoItemInDb.ItemDueDate = todoItem.ItemDueDate;
            }

            if (ModelState.IsValid)
            {
                await _todoItemService.Save(todoItemInDb);
                return RedirectToAction(nameof(Index));
            }

            return View(todoItem);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoItem = await _todoItemService.GetById(id.Value);
            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _todoItemService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
