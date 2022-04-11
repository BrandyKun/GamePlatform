using System.Globalization;
using GamingPlatform.Application.Common.Interfaces;
using GamingPlatform.Application.TodoLists.Queries.ExportTodos;
using GamingPlatform.Infrastructure.Files.Maps;
using CsvHelper;

namespace GamingPlatform.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
