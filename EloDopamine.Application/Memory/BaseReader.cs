using EloDopamine.Api.Math;

namespace EloDopamine.Application.Memory;

public abstract class BaseReader : IReader
{
    public float ReadFloat(int offset)
    {
        return BitConverter.ToSingle(Segment(offset, 4));
    }

    public int ReadInt(int offset)
    {
        return BitConverter.ToInt32(Segment(offset, 4));
    }

    public long ReadLong(int offset)
    {
        return BitConverter.ToInt64(Segment(offset, 8));
    }
    
    public bool ReadBool(int offset)
    {
        return BitConverter.ToBoolean(Segment(offset, 1));
    }

    public byte ReadByte(int offset)
    {
        return Segment(offset, 1)[0];
    }

    public IVector3 ReadVector(int offset)
    {
        var x = ReadFloat(offset);
        var y = ReadFloat(offset + 4);
        var z = ReadFloat(offset + 8);

        return new Vector3(x, y, z);
    }

    protected abstract ArraySegment<byte> Segment(int offset, int size);
}