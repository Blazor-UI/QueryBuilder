namespace QueryBuilder.Enums;

/// <summary>
///     Enum representing various date comparison operators used in date filtering.
/// </summary>
public enum DateOperator
{
    /// <summary>
    ///     Represents the equality comparison operator for dates.
    /// </summary>
    Equals,

    /// <summary>
    ///     Represents the inequality comparison operator for dates.
    /// </summary>
    NotEquals,

    /// <summary>
    ///     Represents the less than comparison operator for dates.
    /// </summary>
    LessThan,

    /// <summary>
    ///     Represents the greater than comparison operator for dates.
    /// </summary>
    GreaterThan,

    /// <summary>
    ///     Represents the less than or equal to comparison operator for dates.
    /// </summary>
    LessThanOrEqual,

    /// <summary>
    ///     Represents the greater than or equal to comparison operator for dates.
    /// </summary>
    GreaterThanOrEqual,

    /// <summary>
    ///     Represents the between comparison operator for dates.
    /// </summary>
    Between,

    /// <summary>
    ///     Represents the not between comparison operator for dates.
    /// </summary>
    NotBetween,

    /// <summary>
    ///     Represents the in comparison operator for dates.
    /// </summary>
    In,

    /// <summary>
    ///     Represents the not in comparison operator for dates.
    /// </summary>
    NotIn
}
