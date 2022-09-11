using System.Diagnostics;
using System.Text;

namespace EloDopamine.Application.Memory;

public class MemoryReader : BaseReader, IMemoryReader
{
	private readonly IntPtr _handle;

	public MemoryReader(Process process)
	{
		_handle = process.Handle;
	}

	public byte[] ReadBytes(int offset, int size)
	{
		return Segment(offset, size).ToArray();
	}

	protected override ArraySegment<byte> Segment(int offset, int size)
	{
		var bytesRead = 0;
		var buff = new byte[size];
		Native.ReadProcessMemory(_handle, new IntPtr(offset), buff, size, ref bytesRead);
		return buff;
	}

	public string ReadString(int offset)
	{
		/*
		 * Less ghetto but still idk its fucking stupid. May throw exception in future
		 */
		
		var len = ReadInt(offset + 16); // normal string is usually 16 bytes of non-pointer so offset + 16 = length
		int address;
		
		if (len is < 1 or > 200) // if length is 0 or > 200 it means this value is not actual string length
		{
			len = ReadInt(offset + 4); // offset + 4 = length of char map
			address = ReadInt(offset); // actual char map
		}
		else
		{
			address = len >= 16 ? ReadInt(offset) : offset;
		}
		
		var bytes = ReadBytes(address, len);

		return Encoding.ASCII.GetString(bytes);
	}
}