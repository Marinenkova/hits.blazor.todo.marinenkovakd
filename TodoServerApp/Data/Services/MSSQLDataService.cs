using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
	public class MSSQLDataService(ApplicationDbContext context) : IDataService
	{
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
		{
			return await context.TaskItems.ToArrayAsync();
		}

        public async Task SaveAsync(TaskItem item)
        {
            await context.TaskItems.AddAsync(item);
            await context.SaveChangesAsync();
        }
    }
}
