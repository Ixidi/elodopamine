namespace EloDopamine.Application.Utils;

public static class MatrixUtils
{

    public static float[] Multiply4X4Matrices(float[] a, float[] b)
    {
        if (a.Length != 16 || b.Length != 16)
        {
            throw new ArgumentException("matrices length must be 16.");
        }
        
        var result = new float[16];
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 4; j++)
            {
                var c = 0f;
                for (var k = 0; k < 4; k++)
                {
                    c += a[(i * 4) + k] * b[(k * 4) + j];
                }

                result[(i * 4) + j] = c;
            }
        }

        return result;
    }
    
}