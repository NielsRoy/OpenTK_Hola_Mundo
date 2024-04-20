using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Face
    {
        public Color4 color { get; set; }
        public List<Vertex> vertices { get; set; }
        //List<Vector3> normals;    //Para las texturas

        public Face()
        {
            vertices = new List<Vertex>();
            color = Color4.Gray;
        }

        public Face(Color4 color)
        {
            vertices = new List<Vertex>();
            this.color = color;
        }

        //public List<Vector3> Vertices { get { return vertices; } }

        public List<Vertex> GetVertices()
        {
            return vertices;
        }

        public void AddVertex(float x, float y, float z)
        {
            vertices.Add(new Vertex(x, y, z));
        }

        public void Draw(Vertex center)
        {
            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            foreach (Vertex v in vertices)
            {
                GL.Vertex3(center.x + v.x, center.y + v.y, center.z + v.z);
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vertex v in vertices)
            {
                GL.Vertex3(center.x + v.x, center.y + v.y, center.z + v.z);
            }
            GL.End();
        }

    }
}
