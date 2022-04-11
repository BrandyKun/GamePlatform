using GamingPlatform.Application.Common.Mappings;
using GamingPlatform.Domain.Entities;

namespace GamingPlatform.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
