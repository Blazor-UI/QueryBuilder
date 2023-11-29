namespace QueryBuilder.Themes.Models;

/// <summary>
///     Represents a light color palette.
/// </summary>
public class ThemeLight : Theme
{
    /// <inheritdoc />
    public override string Group { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string GroupText { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string Filter { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string FilterText { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string Operator { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string OperatorText { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string Value { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ValueText { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string Remove { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string Add { get; set; } = string.Empty;
}
