namespace QueryBuilder.Enums;

/// <summary>
///     Enum representing logical operators used to group conditions in filtering.
/// </summary>
public enum GroupOperator
{
    /// <summary>
    ///     Represents the logical AND operator, requiring all conditions to be true.
    /// </summary>
    And,

    /// <summary>
    ///     Represents the logical OR operator, requiring at least one condition to be true.
    /// </summary>
    Or
}
