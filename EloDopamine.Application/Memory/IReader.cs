using EloDopamine.Api.Math;

namespace EloDopamine.Application.Memory;

public interface IReader
{

    float ReadFloat(int offset);
    int ReadInt(int offset);
    bool ReadBool(int offset);
    byte ReadByte(int offset);

    IVector3 ReadVector(int offset);

}