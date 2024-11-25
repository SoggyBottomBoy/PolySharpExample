using System.Diagnostics.CodeAnalysis;

namespace PolySharpExample;

internal class RequiredExample
{
    [SetsRequiredMembers]
    public RequiredExample(string name)
    {
        Name = name;
    }

    public required string Name { get; set; }
}
