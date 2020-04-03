using System.Collections.Generic;
using System.Diagnostics;

namespace ITI.UI.DP.ShapreAdapter
{
    class DrawerClient
    {
        List<IShape> Shapes = new List<IShape>();

        public List<IShape> GetShapes()
        {
            return Shapes;
        }

        public void AddShape(IShape shape)
        {
            Debug.WriteLine($"adding {shape.GetType().Name}");
            Shapes.Add(shape);
        }

        public void Draw()
        {
            if (Shapes.Count == 0)
            {
                Debug.WriteLine("Nothing to draw");
            }
            else
            {
                Shapes.ForEach(shape => shape.Draw());
            }
        }
        public void Resize()
        {
            if (Shapes.Count == 0)
            {
                Debug.WriteLine("Nothing to resize");
            }
            else
            {
                Shapes.ForEach(shape => shape.Resize());
            }
        }
    }
}