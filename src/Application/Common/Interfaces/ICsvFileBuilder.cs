using GamingPlatform.Application.TodoLists.Queries.ExportTodos;

namespace GamingPlatform.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
