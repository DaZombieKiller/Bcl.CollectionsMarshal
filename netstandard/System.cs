namespace System;

public class Object
{
}

public abstract class Attribute
{
}

public sealed class AttributeUsageAttribute : Attribute
{
    public bool AllowMultiple { get; set; }

    public bool Inherited { get; set; }

    public AttributeUsageAttribute(AttributeTargets validOn)
    {
    }
}

[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
public sealed class FlagsAttribute : Attribute
{
}

[Flags]
public enum AttributeTargets
{
    Assembly    = 1 << 0,
    Class       = 1 << 2,
    Struct      = 1 << 3,
    Enum        = 1 << 4,
    Constructor = 1 << 5,
    Method      = 1 << 6
}

#if NETSTANDARD2_1_OR_GREATER
public readonly ref struct Span<T>
{
    public Span(T[] array, int start, int length)
    {
    }
}
#endif

public abstract class ValueType
{
}

public abstract class Enum : ValueType
{
}

public struct RuntimeTypeHandle
{
}

public abstract class Type
{
    public bool IsPrimitive { get => default; }
    public bool IsEnum { get => default; }
    public static Type? GetTypeFromHandle(RuntimeTypeHandle handle) => default;
}

public abstract class Array
{
    public static void Clear(Array array, int index, int length) { }
}

public class Exception
{
}

public class NullReferenceException : Exception
{
}

public class ArgumentOutOfRangeException : Exception
{
    public ArgumentOutOfRangeException(string? paramName, string? message) { }
}

public sealed class String
{
}

public struct Void
{
}

public struct Boolean
{
}

public struct Char
{
}

public struct Byte
{
}

public struct SByte
{
}

public struct UInt16
{
}

public struct Int16
{
}

public struct UInt32
{
}

public struct Int32
{
}

public struct UInt64
{
}

public struct Int64
{
}
