namespace TodoServerApp.Data.Interfaces
{
    public interface IDataServise
    {
        Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
    }
}
