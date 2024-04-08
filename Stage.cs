using OpenTK;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Stage
    {
        private Vector3 center;
        private Dictionary<string, Object> objects;

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
            Axises.DrawFloor(center, 60);
            foreach (KeyValuePair<string, Object> obj in objects)
            {
                obj.Value.Draw();
            }
        }
    }
}
