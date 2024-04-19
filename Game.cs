using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace OpenTK_Hola_Mundo
{
    public class Game : GameWindow
    {
        Stage stage;
        float theta = 0.0f;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        //This function runs one time, when the window first opens.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

            Object tv = new Object(10.0f, 1.0f, -6.0f);
            Object tv2 = new Object(-25.0f, 5.0f, 0.0f);
            tv.setFaces(Television.getFaces());
            tv2.setFaces(Television.getFaces());
            Object flower = new Object(24.0f, 1.0f, 3.0f);
            flower.setFaces(Flower.getFaces());
            Object speaker = new Object(-7.0f, 1.0f, -10.0f);
            speaker.setFaces(Speaker.getFaces());

            stage = new Stage(5.0f, 4.0f, -10.0f);
            stage.AddObject("tv-1", tv);
            //stage.AddObject("tv-2", tv2);
            //stage.AddObject("fw-1", flower);
            //stage.AddObject("spk-1", speaker);
            stage.Serialize();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -45.0f);
            //GL.Rotate(theta, 1.0, 0.0, 0.0);
            GL.Rotate(25.0f, 1.0, 0.0, 0.0);
            GL.Rotate(theta, 0.0, 0.5, 0.0);

            Axises.Draw(new Vector3(0, 0, 0), 30);

            stage.Draw();

            theta += 1.0f;
            if (theta > 360) theta -= 360; 

            Context.SwapBuffers();
        }

        //This function runs every time the window gets resized.
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Frustum(-1.0f, 1.0f, -1.0f, 1.0f, 0.8f, 100.0f);
            
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
