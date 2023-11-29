namespace QueryBuilder.Themes.Models;

/// <summary>
///     An abstract class which a palette of colors used for the component.
/// </summary>
public abstract class Theme
{
    /// <summary>
    ///     Gets or sets the group color.
    /// </summary>
    public virtual string Group { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the text color for group.
    /// </summary>
    public virtual string GroupText { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the filter color.
    /// </summary>
    public virtual string Filter { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the text color for filter.
    /// </summary>
    public virtual string FilterText { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the operator color.
    /// </summary>
    public virtual string Operator { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the text color for operator.
    /// </summary>
    public virtual string OperatorText { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the value color.
    /// </summary>
    public virtual string Value { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the text color for value.
    /// </summary>
    public virtual string ValueText { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the remove icon color.
    /// </summary>
    public virtual string Remove { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the add icon color.
    /// </summary>
    public virtual string Add { get; set; } = string.Empty;
}
