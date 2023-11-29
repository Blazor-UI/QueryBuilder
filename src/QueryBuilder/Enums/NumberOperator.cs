namespace QueryBuilder.Enums;

/// <summary>
///     Enum representing various numeric comparison operators used in filtering.
/// </summary>
public enum NumberOperator
{
    /// <summary>
    ///     Represents the equality comparison operator for numbers.
    /// </summary>
    Equals,

    /// <summary>
    ///     Represents the inequality comparison operator for numbers.
    /// </summary>
    NotEquals,

    /// <summary>
    ///     Represents the less than comparison operator for numbers.
    /// </summary>
    LessThan,

    /// <summary>
    ///     Represents the greater than comparison operator for numbers.
    /// </summary>
    GreaterThan,

    /// <summary>
    ///     Represents the less than or equal to comparison operator for numbers.
    /// </summary>
    LessThanOrEqual,

    /// <summary>
    ///     Represents the greater than or equal to comparison operator for numbers.
    /// </summary>
    GreaterThanOrEqual,

    /// <summary>
    ///     Represents the between comparison operator for numbers.
    /// </summary>
    Between,

    /// <summary>
    ///     Represents the not between comparison operator for numbers.
    /// </summary>
    NotBetween,

    /// <summary>
    ///     Represents the in comparison operator for numbers.
    /// </summary>
    In,

    /// <summary>
    ///     Represents the not in comparison operator for numbers.
    /// </summary>
    NotIn
}
