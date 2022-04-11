using GamingPlatform.Application.Common.Exceptions;
using GamingPlatform.Application.TodoLists.Commands.CreateTodoList;
using GamingPlatform.Application.TodoLists.Commands.DeleteTodoList;
using GamingPlatform.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace GamingPlatform.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand { Id = 99 };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand
        {
            Id = listId
        });

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
