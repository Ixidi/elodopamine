namespace EloDopamine.Api.Math;

public interface IVector2
{
    float X { get; }
    float Y { get; }

    public static IVector2 operator +(IVector2 a, IVector2 b)
    {
        return a.Add(b);
    }

    public static IVector2 operator -(IVector2 a, IVector2 b)
    {
        return a.Subtract(b);
    }

    public static IVector2 operator *(IVector2 a, float multiplier)
    {
        return a.Multiply(multiplier);
    }

    public static IVector2 operator *(float multiplier, IVector2 a)
    {
        return a.Multiply(multiplier);
    }

    public static IVector2 operator /(IVector2 a, float divisor)
    {
        return a.Multiply(divisor);
    }

    public static IVector2 operator /(float divisor, IVector2 a)
    {
        return a.Multiply(divisor);
    }

    float Length();

    IVector2 Normalize();

    IVector2 Add(IVector2 vec);
    IVector2 Add(float x, float y);

    IVector2 Subtract(IVector2 vec);
    IVector2 Subtract(float x, float y);

    IVector2 Multiply(float multiplier);
    IVector2 Divide(float divisor);
}