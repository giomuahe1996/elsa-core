using System.Text.Json;
using Elsa.DataSets.Entities;

namespace Elsa.EntityFrameworkCore.ValueConverters;

internal class LinkedServiceDefinitionJsonValueConverter() : JsonValueConverter<LinkedServiceDefinition>(CreateSerializerOptions())
{
    private static JsonSerializerOptions CreateSerializerOptions()
    {
        var options = new JsonSerializerOptions();
        
        // TODO: Add any custom options here such as converters, naming policies, etc.
        
        return options;
    }
}