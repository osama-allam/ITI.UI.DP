using System.Linq;

namespace ITI.UI.DP.ShapreAdapter
{

    class Program
    {
        static void Main(string[] args)
        {
            DrawerClient drawer = new DrawerClient();
            drawer.AddShape(new Circle());
            drawer.AddShape(new Rectangle());
            var shape = new GeometricShapeObjectAdapter(new Triangle());
            drawer.AddShape(shape);
            drawer.Draw();
            drawer.Resize();
        }
    }
}
