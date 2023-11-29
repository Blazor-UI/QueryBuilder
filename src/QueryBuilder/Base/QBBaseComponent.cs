namespace QueryBuilder;

using Microsoft.AspNetCore.Components;

/// <summary>
///     Base component.
/// </summary>
public abstract class QBBaseComponent : ComponentBase
{
    /// <summary>
    ///     User class name, separated by space
    /// </summary>
    [Parameter]
    public string? Class { get; set; }

    /// <summary>
    ///     InputAttributes carries all attributes you add to the component that don't match any of its parameters.
    ///     They will be splatted onto the underlying HTML tag.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object?> ComponentAttributes { get; set; } = new();
}
