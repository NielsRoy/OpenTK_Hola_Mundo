using Newtonsoft.Json;
using OpenTK;
using System.Collections.Generic;
using System.IO;

namespace OpenTK_Hola_Mundo
{
    internal class Object
    {
        public Vertex center { get; set; }
        public List<Face> faces { get; set; }

        public Object() { }

        public Object(float x, float y, float z)
        {
            center = new Vertex(x, y, z);
            faces = new List<Face>();
        }

        public Object(string filePath)
        {
            using (StreamReader fileReader = new StreamReader(filePath))
            {
                Object stage = JsonConvert.DeserializeObject<Object>(fileReader.ReadToEnd());
                center = stage.center;
                faces = stage.faces;
            }
        }
        
        public void Draw()
        {
            Axises.Draw(center, 10);
            foreach (Face f in faces)
            {
                f.Draw(center);
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
