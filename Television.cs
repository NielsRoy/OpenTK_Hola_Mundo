using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_Hola_Mundo
{
    internal class Television
    {
        private Vector3 center;
            
        public Television(Vector3 center)
        {
            this.center = center;
        }

        public Television(float x, float y, float z)
        {
            center = new Vector3(x, y, z);
        }

        public void Draw()
        {
            GL.Color4(Color4.White);

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.End();

            //----

            //GL.Color4(Color4.Gray);

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.End();

            //--

            //GL.Color4(Color4.Red);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.End();

            //--

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.End();

            //--

            GL.Begin(BeginMode.LineLoop);   //Quads
            GL.Vertex3(0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.End();

            //-- Botones

            //GL.Color4(Color4.White);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);
            GL.End();

            //----

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);
            GL.End();

            //---- Cuello

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);
            GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);
            GL.End();

            //---- Base

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.23f + center.X, 0.03f + center.Y, -0.11f + center.Z);
            GL.Vertex3(-0.23f + center.X, 0.03f + center.Y, -0.11f + center.Z);
            GL.Vertex3(-0.23f + center.X, 0.03f + center.Y, 0.1f + center.Z);
            GL.Vertex3(0.23f + center.X, 0.03f + center.Y, 0.1f + center.Z);
            GL.End();

            //----

            //--- Relleno

            //GL.Color4(Color4.Gray);
            GL.Color4(Color4.DimGray);
            GL.Begin(BeginMode.Quads);

            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);

            GL.Vertex3(-0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            
            GL.Vertex3(-0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            
            GL.Vertex3(0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);

            //----

            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);

            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);

            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);

            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.01f + center.Z);

            //--
            
            GL.Vertex3(-0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.67f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.03f + center.Z);

            //--- PANTALLA
            GL.Color4(Color4.Black);
            GL.Vertex3(0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.40f + center.X, 0.63f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.40f + center.X, 0.20f + center.Y, -0.01f + center.Z);

            GL.Color4(Color4.DimGray);
            //---
            GL.Vertex3(-0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);

            GL.Vertex3(-0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);

            GL.Vertex3(-0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);

            GL.Vertex3(0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.12f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.43f + center.X, 0.65f + center.Y, -0.03f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);

            //--

            //Quads
            GL.Vertex3(0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.61f + center.Y, -0.09f + center.Z);
            GL.Vertex3(-0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);
            GL.Vertex3(0.37f + center.X, 0.15f + center.Y, -0.09f + center.Z);


            //-- Botones

            //GL.Color4(Color4.DimGray);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);

            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);

            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);

            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);
            GL.Vertex3(0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);

            //----
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.034f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.1f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.01f + center.Z);
            GL.Vertex3(-0.45f + center.X, 0.17f + center.Y, -0.034f + center.Z);

            //---- Cuello

            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);

            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);

            GL.Vertex3(-0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);
            GL.Vertex3(-0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);

            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.08f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.03f + center.Y, -0.037f + center.Z);
            GL.Vertex3(0.05f + center.X, 0.2f + center.Y, -0.037f + center.Z);

            //---- Base

            GL.Vertex3(0.23f + center.X, 0.03f + center.Y, -0.11f + center.Z);
            GL.Vertex3(-0.23f + center.X, 0.03f + center.Y, -0.11f + center.Z);
            GL.Vertex3(-0.23f + center.X, 0.03f + center.Y, 0.1f + center.Z);
            GL.Vertex3(0.23f + center.X, 0.03f + center.Y, 0.1f + center.Z);

            GL.End();
        }
    }
}
