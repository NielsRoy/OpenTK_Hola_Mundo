using Newtonsoft.Json;
using OpenTK;
using System.Collections.Generic;
using System.IO;

namespace OpenTK_Hola_Mundo
{
    internal class Object
    {
        public Vertex center { get; set; }
        public Vertex origin { get; set; }
        public List<Face> faces { get; set; }

        public Object() 
        {
            center = new Vertex(0, 0, 0);
        }

        public Object(float x, float y, float z)
        {
            center = new Vertex(x, y, z);
            faces = new List<Face>();
        }

        public Object(string filePath)
        {
            using (StreamReader fileReader = new StreamReader(filePath))
            {
                Object obj = JsonConvert.DeserializeObject<Object>(fileReader.ReadToEnd());
                center = obj.center;
                faces = obj.faces;
            }

            //AddFaces(faces);
        }

        public void setOrigin(Vertex origin)
        {
            this.origin = origin;
            center.x += origin.x;
            center.y += origin.y;
            center.z += origin.z;

            foreach (Face face in faces)
            {
                face.origin = center;
                face.Translate(center.x, center.y, center.z);
            }
        }

        public void Translate(float x, float y, float z)
        {
            foreach (Face face in faces)
            {
                face.Translate(x, y, z);
            }
        }

        public void ScaleWithStage(float n)
        {
            foreach (Face face in faces)
            {
                face.ScaleWithStage(n);
            }
        }

        public void Scale(float n)
        {
            foreach (Face face in faces)
            {
                face.Scale(n);
            }
        }

        public void RotateWithStage(string axis, float grades)
        {
            foreach (Face f in faces)
            {
                f.RotateWithStage(axis, grades);
            }
        }

        public void Rotate(string axis, float grades)
        {
            foreach (Face f in faces)
            {
                f.Rotate(axis, grades);
            }
        }

        public void Draw()
        {
            //Axises.Draw(center, 10);
            foreach (Face f in faces)
            {
                f.Draw();
            }
        }

        public void Serialize(string filename = "object.json")
        {
            filename = filename.Contains(".json") ? filename : filename + ".json";
            string json = JsonConvert.SerializeObject(this);
            using (StreamWriter fileWriter = new StreamWriter(filename))
            {
                fileWriter.WriteLine(json);
            }
        }
    }
}
