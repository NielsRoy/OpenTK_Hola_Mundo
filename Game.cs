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

            //Object tv = new Object(10.0f, 1.0f, -6.0f);
            //Object tv2 = new Object(-25.0f, 5.0f, 0.0f);
            //tv.faces = Television.getFaces();
            //tv.Serialize("tv.json");
            //tv2.faces = Television.getFaces();
            //Object flower = new Object(24.0f, 1.0f, 3.0f);
            //flower.faces = Flower.getFaces();
            //flower.Serialize("flower.json");
            //Object speaker = new Object(-7.0f, 1.0f, -10.0f);
            //speaker.faces = Speaker.getFaces();
            //speaker.Serialize("speaker.json");

            Object tv = new Object("tv.json");
            //Object flower = new Object("flower.json");
            Object speaker = new Object("speaker.json");

            Object floor = new Object();
            floor.faces = Floor.getFaces();

            stage = new Stage(5.0f, 4.0f, -10.0f);
            stage.AddObject("tv-1", tv);
            //stage.AddObject("tv-2", tv2);
            //stage.AddObject("fw-1", flower);
            stage.AddObject("spk-1", speaker);
            stage.AddObject("flr-1", floor);
            //stage.Serialize();


            //stage = new Stage("stage.json");
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -45.0f);
            //GL.Rotate(theta, 1.0, 0.0, 0.0);
            GL.Rotate(25.0f, 1.0, 0.0, 0.0);
            //GL.Rotate(theta, 0.0, 0.5, 0.0);

            Axises.Draw(new Vertex(0, 0, 0), 30);

            //Object spk = stage.GetObject("spk-1");
            //spk.Rotate("y", 2);
            //stage.Rotate("y", 1);
            stage.Draw();
            Object tv = stage.GetObject("spk-1");
            tv.Rotate("y", 2);
            //tv.Scale(1.01f);

            //theta += 1.0f;
            //if (theta > 360) theta -= 360; 

            Context.SwapBuffers();
        }

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
