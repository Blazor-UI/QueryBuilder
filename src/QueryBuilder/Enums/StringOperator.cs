namespace QueryBuilder.Enums;

/// <summary>
///     Enum representing various string comparison operators used in filtering.
/// </summary>
public enum StringOperator
{
    /// <summary>
    ///     Represents the operator for checking if a string starts with a specified value.
    /// </summary>
    StartsWith,

    /// <summary>
    ///     Represents the operator for checking if a string ends with a specified value.
    /// </summary>
    EndsWith,

    /// <summary>
    ///     Represents the operator for checking if a string contains a specified value.
    /// </summary>
    Contains,

    /// <summary>
    ///     Represents the operator for checking if a string does not contain a specified value.
    /// </summary>
    NotContains,

    /// <summary>
    ///     Represents the equality comparison operator for strings.
    /// </summary>
    Equals,

    /// <summary>
    ///     Represents the inequality comparison operator for strings.
    /// </summary>
    NotEquals,

    /// <summary>
    ///     Represents the in comparison operator for strings.
    /// </summary>
    In,

    /// <summary>
    ///     Represents the not in comparison operator for strings.
    /// </summary>
    NotIn,

    /// <summary>
    ///     Represents the operator for checking if a string is empty.
    /// </summary>
    Empty,

    /// <summary>
    ///     Represents the operator for checking if a string is not empty.
    /// </summary>
    NotEmpty,

    /// <summary>
    ///     Represents the operator for checking if a string is null.
    /// </summary>
    Null,

    /// <summary>
    ///     Represents the operator for checking if a string is not null.
    /// </summary>
    NotNull
}
