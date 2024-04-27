using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    public class Face
    {
        public Color4 color { get; set; }
        public Vertex origin { get; set; }
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

        public List<Vertex> GetVertices()
        {
            return vertices;
        }

        public void RotateWithStage(string axis, float grades)
        {
            float radians = MathHelper.DegreesToRadians(grades);
            Matrix3 rotation;
            if (axis == "x")
                rotation = Matrix3.CreateRotationX(radians);
            else if (axis == "y")
                rotation = Matrix3.CreateRotationY(radians);
            else
                rotation = Matrix3.CreateRotationZ(radians);

            foreach (Vertex v in vertices)
            {
                Vector3 vector = new Vector3(v.x, v.y, v.z);                   
                Vector3 rotated = Vector3.Transform(vector, rotation);
                v.x = rotated.X;
                v.y = rotated.Y;
                v.z = rotated.Z;
            }
        }
        public void Rotate(string axis, float grades)
        {
            Translate(-origin.x, -origin.y, -origin.z);

            float radians = MathHelper.DegreesToRadians(grades);
            Matrix3 rotation;
            if (axis == "x")
                rotation = Matrix3.CreateRotationX(radians);
            else if (axis == "y")
                rotation = Matrix3.CreateRotationY(radians);
            else
                rotation = Matrix3.CreateRotationZ(radians);

            foreach (Vertex v in vertices)
            {
                Vector3 vector = new Vector3(v.x, v.y, v.z);
                Vector3 rotated = Vector3.Transform(vector, rotation);
                v.x = rotated.X;
                v.y = rotated.Y;
                v.z = rotated.Z;
            }

            Translate(origin.x, origin.y, origin.z);
        }

        public void Translate(float x, float y, float z)
        {
            foreach (Vertex v in vertices)
            {
                v.x += x;
                v.y += y;
                v.z += z;
            }
        }

        public void Scale(float n)
        {
            Translate(-origin.x, -origin.y, -origin.z);

            foreach (Vertex v in vertices)
            {
                v.x *= n;
                v.y *= n;
                v.z *= n;
            }

            Translate(origin.x, origin.y, origin.z);
        }

        public void ScaleWithStage(float n)
        {
            foreach (Vertex v in vertices)
            {
                v.x *= n;
                v.y *= n;
                v.z *= n;
            }
        }

        public void AddVertex(float x, float y, float z)
        {
            vertices.Add(new Vertex(x, y, z));
        }

        public void Draw()
        {
            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            foreach (Vertex v in vertices)
            {
                GL.Vertex3(v.x, v.y, v.z);
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vertex v in vertices)
            {
                GL.Vertex3(v.x, v.y, v.z);
            }
            GL.End();
        }

    }
}
