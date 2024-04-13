using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Face
    {
        private List<Vector3> vertices;
        private Color4 color;
        //List<Vector3> normals;    //Para las texturas

        public Face()
        {
            vertices = new List<Vector3>();
            color = Color4.Gray;
        }

        public Face(Color4 color)
        {
            vertices = new List<Vector3>();
            this.color = color;
        }

        //public List<Vector3> Vertices { get { return vertices; } }

        public List<Vector3> GetVertices()
        {
            return vertices;
        }

        public void AddVertex(float x, float y, float z)
        {
            vertices.Add(new Vector3(x, y, z));
        }

        public void Draw(Vector3 center)
        {
            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            foreach (Vector3 v in vertices)
            {
                GL.Vertex3(center.X + v.X, center.Y + v.Y, center.Z + v.Z);
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vector3 v in vertices)
            {
                GL.Vertex3(center.X + v.X, center.Y + v.Y, center.Z + v.Z);
            }
            GL.End();
        }

    }
}
