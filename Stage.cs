using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
using System.IO;

namespace OpenTK_Hola_Mundo
{
    internal class Stage
    {
        public Vertex center { get; set; }
        public Dictionary<string, Object> objects { get; set; }

        public Stage() { }

        public Stage(float x, float y, float z)
        {
            center = new Vertex(x, y, z);
            objects = new Dictionary<string, Object>();
        }

        public Stage(string filePath)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(filePath))
                {
                    Stage stage = JsonConvert.DeserializeObject<Stage>(fileReader.ReadToEnd());
                    center = stage.center;
                    objects = stage.objects;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"No se pudo encontrar el archivo: {ex.Message}");
            }
        }

        public Vertex GetCenter()
        {
            return center;
        }

        public Object GetObject(string name)
        {
            return objects.ContainsKey(name) ? objects[name] : null;
        }

        public void AddObject(string name, Object obj)
        {
            objects.Add(name, obj);
            obj.center.x += center.x;
            obj.center.y += center.y;
            obj.center.z += center.z;
        }

        public void Draw()
        {
            if (center == null || objects == null)
                return;

            Axises.Draw(center, 30);
            //Si dibujo aqui el piso la parte de los objetos que esten debajo del piso no se veran
            foreach (Object obj in objects.Values)
            {
                obj.Draw();
            }
            Axises.DrawFloor(center, 60);
        }

        public void Serialize(string filename = "stage.json")
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
