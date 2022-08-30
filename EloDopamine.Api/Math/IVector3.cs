namespace EloDopamine.Api.Math;

public interface IVector3
{
    float X { get; }
    float Y { get; }
    float Z { get; }

    public static IVector3 operator +(IVector3 a, IVector3 b)
    {
        return a.Add(b);
    }

    public static IVector3 operator -(IVector3 a, IVector3 b)
    {
        return a.Subtract(b);
    }

    public static IVector3 operator *(IVector3 a, float multiplier)
    {
        return a.Multiply(multiplier);
    }

    public static IVector3 operator *(float multiplier, IVector3 a)
    {
        return a.Multiply(multiplier);
    }

    public static IVector3 operator /(IVector3 a, float divisor)
    {
        return a.Multiply(divisor);
    }

    public static IVector3 operator /(float divisor, IVector3 a)
    {
        return a.Multiply(divisor);
    }

    float Length();

    IVector3 Normalize();

    IVector3 Add(IVector3 vec);
    IVector3 Add(float x, float y, float z);

    IVector3 Subtract(IVector3 vec);
    IVector3 Subtract(float x, float y, float z);

    IVector3 Multiply(float multiplier);
    IVector3 Divide(float divisor);
}