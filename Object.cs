using OpenTK;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Object
    {
        private Vector3 center;
        private List<Face> faces;

        public Object(float x, float y, float z)
        {
            center = new Vector3(x, y, z);
            faces = new List<Face>();
        }

        public Vector3 GetCenter()
        {
            return center;
        }

        public void AddToStage(Stage stage)
        {
            center.X += stage.GetCenter().X;
            center.Y += stage.GetCenter().Y;
            center.Z += stage.GetCenter().Z;
        }

        public void setFaces(List<Face> faces)
        {
            this.faces = faces;
        }

        public void AddFace(Face f)
        {
            faces.Add(f);
        }

        public void Draw()
        {
            Axises.Draw(center, 10);
            foreach (Face f in faces)
            {
                f.Draw(center);
            }
        }

    }
}
