namespace EloDopamine.Api.Math;

public class Vector3 : IVector3
{
    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public float X { get; }
    public float Y { get; }
    public float Z { get; }

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