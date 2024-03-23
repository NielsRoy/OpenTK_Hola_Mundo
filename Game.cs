using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace OpenTK_Hola_Mundo
{
    public class Game : GameWindow
    {
        float[] vertices = {
            -0.5f, -0.5f, 0.0f, //Bottom-left vertex
             0.5f, -0.5f, 0.0f, //Bottom-right vertex
             0.0f,  0.5f, 0.0f  //Top vertex
        };

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        //This function runs one time, when the window first opens.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);


            GL.Enable(EnableCap.DepthTest);

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -3.0f);
            GL.Rotate(25.0f, 1.0, 0.0, 0.0);
            GL.Rotate(-25.0f, 0.0, 1.0, 0.0);

            GL.Begin(BeginMode.Lines);
            GL.Color4(Color4.Cyan);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(1.0f, 0.0f, 0.0f);

            GL.Color4(Color4.Magenta);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 1.0f, 0.0f);

            GL.Color4(Color4.Yellow);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 0.0f, 1.0f);

            GL.End();

            GL.Color4(Color4.White);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.2f, 0.2f, 0.0f);
            GL.Vertex3(0.7f, 0.2f, 0.0f);
            GL.Vertex3(0.7f, 0.5f, 0.0f);
            GL.Vertex3(0.2f, 0.5f, 0.0f);
            GL.End();

            GL.Color4(Color4.Gray);
            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.2f, 0.2f, -0.05f);
            GL.Vertex3(0.7f, 0.2f, -0.05f);
            GL.Vertex3(0.7f, 0.5f, -0.05f);
            GL.Vertex3(0.2f, 0.5f, -0.05f);
            GL.End();



            GL.Begin(BeginMode.Lines);

            GL.Vertex3(0.2f, 0.2f, 0.0f);
            GL.Vertex3(0.2f, 0.2f, -0.05f);

            GL.Vertex3(0.7f, 0.2f, 0.0f);
            GL.Vertex3(0.7f, 0.2f, -0.05f);

            GL.Vertex3(0.7f, 0.5f, 0.0f);
            GL.Vertex3(0.7f, 0.5f, -0.05f);

            GL.Vertex3(0.2f, 0.5f, 0.0f);
            GL.Vertex3(0.2f, 0.5f, -0.05f);

            //Antenas
            GL.Color4(Color4.White);

            GL.Vertex3(0.45f, 0.5f, 0.0f);
            GL.Vertex3(0.35f, 0.6f, 0.0f);

            GL.Vertex3(0.45f, 0.5f, 0.0f);
            GL.Vertex3(0.55f, 0.6f, 0.0f);

            GL.End();

            //GL.Begin(BeginMode.LineLoop);
            //GL.Vertex3(0.25f, 0.25f, -0.06f);
            //GL.Vertex3(0.65f, 0.25f, -0.06f);
            //GL.Vertex3(0.65f, 0.45f, -0.06f);
            //GL.Vertex3(0.25f, 0.45f, -0.06f);
            //GL.End();

            GL.Begin(BeginMode.LineLoop);
            GL.Vertex3(0.22f, 0.22f, 0.0f);
            GL.Vertex3(0.68f, 0.22f, 0.0f);
            GL.Vertex3(0.68f, 0.48f, 0.0f);
            GL.Vertex3(0.22f, 0.48f, 0.0f);
            GL.End();

            Context.SwapBuffers();
        }

        //This function runs every time the window gets resized.
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), Width/Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }
    }
}
