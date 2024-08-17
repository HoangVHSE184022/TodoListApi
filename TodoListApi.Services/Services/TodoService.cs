using TodoListApi.Repositories.Entities;
using TodoListApi.Repositories.Interfaces;
using TodoListApi.Services.Interfaces;

namespace TodoListApi.Services.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return await _todoRepository.GetAllAsync();
        }

        public async Task<TodoItem> GetByIdAsync(int id)
        {
            return await _todoRepository.GetByIdAsync(id);
        }

        public async Task<TodoItem> AddAsync(TodoItem todoItem)
        {
            return await _todoRepository.AddAsync(todoItem);
        }

        public async Task<TodoItem> UpdateAsync(TodoItem todoItem)
        {
            return await _todoRepository.UpdateAsync(todoItem);
        }

        public async Task DeleteAsync(int id)
        {
            await _todoRepository.DeleteAsync(id);
        }
    }
}
