namespace EloDopamine.Api.Math;

public record Vector2(float X, float Y) : IVector2
{
    public float Length()
    {
        return Convert.ToSingle(System.Math.Sqrt(X * X + Y * Y));
    }

    public IVector2 Normalize()
    {
        return Divide(Length());
    }

    public IVector2 Add(IVector2 vec)
    {
        return new Vector2(X + vec.X, Y + vec.Y);
    }

    public IVector2 Add(float x, float y)
    {
        return new Vector2(X + x, Y + y);
    }

    public IVector2 Subtract(IVector2 vec)
    {
        return new Vector2(X - vec.X, Y - vec.Y);
    }

    public IVector2 Subtract(float x, float y)
    {
        return new Vector2(X - x, Y - y);
    }

    public IVector2 Multiply(float multiplier)
    {
        return new Vector2(X * multiplier, Y * multiplier);
    }

    public IVector2 Divide(float divisor)
    {
        return new Vector2(X / divisor, Y / divisor);
    }
}