using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace OpenTK_Hola_Mundo
{
    public class Game : GameWindow
    {
        Television tv;
        Television tv2;


        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        //This function runs one time, when the window first opens.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);

            tv = new Television(new Vector3(0.2f, 0.2f, 0.5f));
            tv2 = new Television(new Vector3(0.5f, 0.5f, 0.0f));
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -3.0f);
            GL.Rotate(25.0f, 1.0, 0.0, 0.0);
            GL.Rotate(-45.0f, 0.0, 1.0, 0.0);

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

            tv.Draw();
            tv2.Draw();

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
