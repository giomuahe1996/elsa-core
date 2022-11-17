using Elsa.Workflows.Core.Services;

namespace Elsa.Workflows.Core.Activities.Flowchart.Models;

public record Connection(IActivity Source, IActivity Target, string? SourcePort = default, string? TargetPort = default)
{
    public void Deconstruct(out IActivity source, out IActivity target)
    {
        source = Source;
        target = Target;
    }
}