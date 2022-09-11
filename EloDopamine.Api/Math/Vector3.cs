namespace EloDopamine.Api.Math;

public record Vector3(float X, float Y, float Z) : IVector3
{
    public float Length()
    {
        return Convert.ToSingle(System.Math.Sqrt(X * X + Y * Y + Z * Z));
    }

    public IVector3 Normalize()
    {
        return Divide(Length());
    }

    public IVector3 Add(IVector3 vec)
    {
        return new Vector3(X + vec.X, Y + vec.Y, Z + vec.Z);
    }

    public IVector3 Add(float x, float y, float z)
    {
        return new Vector3(X + z, Y + y, Z + z);
    }

    public IVector3 Subtract(IVector3 vec)
    {
        return new Vector3(X - vec.X, Y - vec.Y, Z - vec.Z);
    }

    public IVector3 Subtract(float x, float y, float z)
    {
        return new Vector3(X - x, Y - y, Z - z);
    }

    public IVector3 Multiply(float multiplier)
    {
        return new Vector3(X * multiplier, Y * multiplier, Z * multiplier);
    }

    public IVector3 Divide(float divisor)
    {
        return new Vector3(X / divisor, Y / divisor, Z / divisor);
    }
}