using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_Hola_Mundo
{
    internal class Axises
    {
        public static void Draw(Vector3 center, int longitude)
        {
            GL.Begin(BeginMode.Lines);
            GL.Color4(Color4.Cyan);
            GL.Vertex3(center.X, center.Y, center.Z);
            GL.Vertex3(center.X + longitude, center.Y, center.Z);
            GL.Color4(Color4.Magenta);
            GL.Vertex3(center.X, center.Y, center.Z);
            GL.Vertex3(center.X, center.Y + longitude, center.Z);
            GL.Color4(Color4.Yellow);
            GL.Vertex3(center.X, center.Y, center.Z);
            GL.Vertex3(center.X, center.Y, center.Z + longitude);
            GL.End();
        }

        public static void DrawFloor(Vector3 center, int longitude)
        {
            int factor = longitude / 2;
            Color4 color = new Color4(0.7f, 0.6f, 0.9f, 0.6f);
            GL.Color4(color);
            GL.Begin(BeginMode.Quads);
            GL.Vertex3(-factor + center.X, 0.0f + center.Y, -factor + center.Z);
            GL.Vertex3(factor + center.X, 0.0f + center.Y, -factor + center.Z);
            GL.Vertex3(factor + center.X, 0.0f + center.Y, factor + center.Z);
            GL.Vertex3(-factor + center.X, 0.0f + center.Y, factor + center.Z);
            GL.End();
        }
    }
}
