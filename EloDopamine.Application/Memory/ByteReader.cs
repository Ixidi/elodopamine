namespace EloDopamine.Application.Memory;

public class ByteReader : BaseReader
{

    private readonly byte[] _bytes;

    public ByteReader(byte[] bytes)
    {
        _bytes = bytes;
    }
    protected override ArraySegment<byte> Segment(int offset, int size)
    {
        return new ArraySegment<byte>(_bytes, offset, size);
    }
    
}