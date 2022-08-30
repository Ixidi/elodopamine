using System.Drawing;
using EloDopamine.Api.Math;

namespace EloDopamine.Api.Draw;

public interface IDrawer
{
    void DrawCircleAt(IVector3 center, float radius, Color color, float thickness, bool filled);
    void DrawLine(IVector2 from, IVector2 to, Color color, float thickness);
    void DrawImage(IImage image, IVector2 pos, IVector2 scale, float rounding, float alpha);
}