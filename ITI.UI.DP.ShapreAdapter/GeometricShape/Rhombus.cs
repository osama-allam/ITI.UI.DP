using System.Diagnostics;

namespace ITI.UI.DP.ShapreAdapter
{
    class Rhombus : IGeometricShape
    {
        public double Diameter1 { get; set; }
        public double Diameter2 { get; set; }

        public Rhombus() : this(1.0d,1.0d)
        {
            
        }
        public Rhombus(double diameter1, double diameter2)
        {
            Diameter1 = diameter1;
            Diameter2 = diameter2;
        }
        public double Area()
        {
            double area = Diameter1 * Diameter2;
            return area;
        }

        public double Perimeter()
        {
            return (Diameter1 * Diameter2) * 2;
        }

        public void DrawShape()
        {
            Debug.WriteLine($"Drawing {this.GetType().Name} with: Area: {Area()} and Perimeter: {Perimeter()}");
        }
    }
}