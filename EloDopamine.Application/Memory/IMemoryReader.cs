namespace EloDopamine.Application.Memory;

public interface IMemoryReader : IReader
{
    byte[] ReadBytes(int offset, int size);
    string ReadString(int offset);
    
}