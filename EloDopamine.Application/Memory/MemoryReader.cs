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
		//DO NOT TOUCH IT!!! it works idk how idk why
		ArraySegment<byte> bytes;
		if (ReadInt(offset + 20) == 15)
		{
			var l = ReadInt(offset + 16);
			bytes = Segment(offset, l);
		}
		else
		{

			var stringAddress = ReadInt(offset);
			var l = ReadInt(offset + 16);
			if (l == 0)
			{
				l = ReadInt(offset + 4);
			}
			
			bytes = Segment(stringAddress, l);
		}
		
		return Encoding.UTF8.GetString(bytes);
	}
}