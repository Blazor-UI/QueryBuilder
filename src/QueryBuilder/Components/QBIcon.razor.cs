namespace QueryBuilder;

using Microsoft.AspNetCore.Components;

/// <summary>
///     Icon component.
/// </summary>
public partial class QBIcon : QBBaseComponent
{
    /// <summary>
    ///     Icon to use can be either SVG path or font icons.
    /// </summary>
    [Parameter]
    public string? Icon { get; set; }

    /// <summary>
    ///     The viewbox size of an svg element.
    /// </summary>
    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";
}
