
using OpenTK;
using System;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Television
    {
        public static List<Face> getFaces()
        {
            List<Face> faces = new List<Face>();

            //--- Relleno
            Face f1 = new Face();
            f1.AddVertex(-0.45f, 0.67f, -0.01f);
            f1.AddVertex(0.45f, 0.67f, -0.01f);
            f1.AddVertex(0.40f, 0.63f, -0.01f);
            f1.AddVertex(-0.40f, 0.63f, -0.01f);
            faces.Add(f1);

            Face f2 = new Face();
            f2.AddVertex(-0.40f, 0.63f, -0.01f);
            f2.AddVertex(-0.45f, 0.67f, -0.01f);
            f2.AddVertex(-0.45f, 0.17f, -0.01f);
            f2.AddVertex(-0.40f, 0.20f, -0.01f);
            faces.Add(f2);

            Face f3 = new Face();
            f3.AddVertex(-0.40f, 0.20f, -0.01f);
            f3.AddVertex(-0.45f, 0.17f, -0.01f);
            f3.AddVertex(0.45f, 0.17f, -0.01f);
            f3.AddVertex(0.40f, 0.20f, -0.01f);
            faces.Add(f3);

            Face f4 = new Face();
            f4.AddVertex(0.40f, 0.20f, -0.01f);
            f4.AddVertex(0.45f, 0.17f, -0.01f);
            f4.AddVertex(0.45f, 0.67f, -0.01f);
            f4.AddVertex(0.40f, 0.63f, -0.01f);
            faces.Add(f4);


            //----
            Face f5 = new Face();
            f5.AddVertex(-0.45f, 0.67f, -0.01f);
            f5.AddVertex(0.45f, 0.67f, -0.01f);
            f5.AddVertex(0.45f, 0.67f, -0.03f);
            f5.AddVertex(-0.45f, 0.67f, -0.03f);
            faces.Add(f5);

            Face f6 = new Face();
            f6.AddVertex(0.45f, 0.67f, -0.01f);
            f6.AddVertex(0.45f, 0.67f, -0.03f);
            f6.AddVertex(0.45f, 0.17f, -0.03f);
            f6.AddVertex(0.45f, 0.17f, -0.01f);
            faces.Add(f6);

            Face f7 = new Face();
            f7.AddVertex(0.45f, 0.17f, -0.01f);
            f7.AddVertex(0.45f, 0.17f, -0.03f);
            f7.AddVertex(-0.45f, 0.17f, -0.03f);
            f7.AddVertex(-0.45f, 0.17f, -0.01f);
            faces.Add(f7);

            Face f8 = new Face();
            f8.AddVertex(-0.45f, 0.17f, -0.01f);
            f8.AddVertex(-0.45f, 0.17f, -0.03f);
            f8.AddVertex(-0.45f, 0.67f, -0.03f);
            f8.AddVertex(-0.45f, 0.67f, -0.01f);
            faces.Add(f8);

            //--
            Face f9 = new Face();
            f9.AddVertex(-0.45f, 0.67f, -0.03f);
            f9.AddVertex(0.45f, 0.67f, -0.03f);
            f9.AddVertex(0.45f, 0.17f, -0.03f);
            f9.AddVertex(-0.45f, 0.17f, -0.03f);
            faces.Add(f9);

            //--- PANTALLA
            Face f10 = new Face();
            f10.AddVertex(0.40f, 0.63f, -0.01f);
            f10.AddVertex(-0.40f, 0.63f, -0.01f);
            f10.AddVertex(-0.40f, 0.20f, -0.01f);
            f10.AddVertex(0.40f, 0.20f, -0.01f);
            faces.Add(f10);

            //---
            Face f11 = new Face();
            f11.AddVertex(-0.43f, 0.65f, -0.03f);
            f11.AddVertex(0.43f, 0.65f, -0.03f);
            f11.AddVertex(0.37f, 0.61f, -0.09f);
            f11.AddVertex(-0.37f, 0.61f, -0.09f);
            faces.Add(f11);

            Face f12 = new Face();
            f12.AddVertex(-0.37f, 0.61f, -0.09f);
            f12.AddVertex(-0.43f, 0.65f, -0.03f);
            f12.AddVertex(-0.43f, 0.12f, -0.03f);
            f12.AddVertex(-0.37f, 0.15f, -0.09f);
            faces.Add(f12);

            Face f13 = new Face();
            f13.AddVertex(-0.37f, 0.15f, -0.09f);
            f13.AddVertex(-0.43f, 0.12f, -0.03f);
            f13.AddVertex(0.43f, 0.12f, -0.03f);
            f13.AddVertex(0.37f, 0.15f, -0.09f);
            faces.Add(f13);

            Face f14 = new Face();
            f14.AddVertex(0.37f, 0.15f, -0.09f);
            f14.AddVertex(0.43f, 0.12f, -0.03f);
            f14.AddVertex(0.43f, 0.65f, -0.03f);
            f14.AddVertex(0.37f, 0.61f, -0.09f);
            faces.Add(f14);

            //--

            //Quads
            Face f15 = new Face();
            f15.AddVertex(0.37f, 0.61f, -0.09f);
            f15.AddVertex(-0.37f, 0.61f, -0.09f);
            f15.AddVertex(-0.37f, 0.15f, -0.09f);
            f15.AddVertex(0.37f, 0.15f, -0.09f);
            faces.Add(f15);


            //-- Botones
            //Derecha
            Face f16 = new Face();
            f16.AddVertex(0.45f, 0.17f, -0.03f);
            f16.AddVertex(0.45f, 0.17f, -0.00f);
            f16.AddVertex(0.45f, 0.1f, -0.00f);
            f16.AddVertex(0.45f, 0.1f, -0.03f);
            faces.Add(f16);

            //Abajo
            Face f17 = new Face();
            f17.AddVertex(0.45f, 0.1f, -0.03f);
            f17.AddVertex(0.45f, 0.1f, -0.00f);
            f17.AddVertex(-0.45f, 0.1f, -0.00f);
            f17.AddVertex(-0.45f, 0.1f, -0.03f);
            faces.Add(f17);

            //Izquierda
            Face f18 = new Face();
            f18.AddVertex(-0.45f, 0.1f, -0.03f);
            f18.AddVertex(-0.45f, 0.1f, -0.00f);
            f18.AddVertex(-0.45f, 0.17f, -0.00f);
            f18.AddVertex(-0.45f, 0.17f, -0.03f);
            faces.Add(f18);

            //Frente
            Face f19 = new Face();
            f19.AddVertex(-0.45f, 0.17f, -0.00f);
            f19.AddVertex(0.45f, 0.17f, -0.00f);
            f19.AddVertex(0.45f, 0.1f, -0.00f);
            f19.AddVertex(-0.45f, 0.1f, -0.00f);
            faces.Add(f19);

            //Atras
            Face f20 = new Face();
            f20.AddVertex(-0.45f, 0.17f, -0.03f);
            f20.AddVertex(0.45f, 0.17f, -0.03f);
            f20.AddVertex(0.45f, 0.1f, -0.03f);
            f20.AddVertex(-0.45f, 0.1f, -0.03f);
            faces.Add(f20);
            //----

            //---- Cuello
            Face f21 = new Face();
            f21.AddVertex(-0.05f, 0.03f, -0.037f);
            f21.AddVertex(0.05f, 0.03f, -0.037f);
            f21.AddVertex(0.05f, 0.2f, -0.037f);
            f21.AddVertex(-0.05f, 0.2f, -0.037f);
            faces.Add(f21);

            Face f22 = new Face();
            f22.AddVertex(-0.05f, 0.2f, -0.037f);
            f22.AddVertex(-0.05f, 0.03f, -0.037f);
            f22.AddVertex(-0.05f, 0.03f, -0.08f);
            f22.AddVertex(-0.05f, 0.2f, -0.08f);
            faces.Add(f22);

            Face f23 = new Face();
            f23.AddVertex(-0.05f, 0.2f, -0.08f);
            f23.AddVertex(-0.05f, 0.03f, -0.08f);
            f23.AddVertex(0.05f, 0.03f, -0.08f);
            f23.AddVertex(0.05f, 0.2f, -0.08f);
            faces.Add(f23);

            Face f24 = new Face();
            f24.AddVertex(0.05f, 0.2f, -0.08f);
            f24.AddVertex(0.05f, 0.03f, -0.08f);
            f24.AddVertex(0.05f, 0.03f, -0.037f);
            f24.AddVertex(0.05f, 0.2f, -0.037f);
            faces.Add(f24);

            //---- Base

            Face f25 = new Face();
            f25.AddVertex(0.23f, 0.03f, -0.11f);
            f25.AddVertex(-0.23f, 0.03f, -0.11f);
            f25.AddVertex(-0.23f, 0.03f, 0.1f);
            f25.AddVertex(0.23f, 0.03f, 0.1f);
            faces.Add(f25);

            Console.WriteLine(faces.Count);

            //Imitando al metodo GL.Scale()
            //Aumentando el tamaño x30
            foreach (Face f in faces)
            {
                List<Vector3> vertices = f.GetVertices();
                for (int i = 0; i < vertices.Count; i++)
                {
                    Vector3 vertex = vertices[i];
                    vertex.X *= 20;
                    vertex.Y *= 20;
                    vertex.Z *= 20;
                    vertices[i] = vertex;
                }
            }
            //Luego este proceso sera pasado a la class Object

            return faces;
        }
    }
}
