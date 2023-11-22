namespace QueryBuilder.Base;

using Microsoft.AspNetCore.Components;

public abstract class QBBaseInput : ComponentBase
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
    public Dictionary<string, object?> InputAttributes { get; set; } = [];
}
