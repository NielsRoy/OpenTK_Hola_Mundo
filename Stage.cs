using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
//using System.Text.Json;


namespace OpenTK_Hola_Mundo
{
    internal class Stage
    {
        public Vector3 center;
        public Dictionary<string, Object> objects;

        public Stage(float x, float y, float z)
        {
            center = new Vector3(x, y, z);
            objects = new Dictionary<string, Object>();
        }

        public Vector3 GetCenter()
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
            obj.AddToStage(this);
        }

        public void Draw()
        {
            Axises.Draw(center, 30);
            //Si dibujo aqui el piso la parte de los objetos que esten debajo del piso no se veran
            foreach (KeyValuePair<string, Object> obj in objects)
            {
                obj.Value.Draw();
            }
            Axises.DrawFloor(center, 60);
        }

        public void Serialize()
        {
            string json = JsonConvert.SerializeObject(this);
            Console.WriteLine(json);
        }
    }
}
