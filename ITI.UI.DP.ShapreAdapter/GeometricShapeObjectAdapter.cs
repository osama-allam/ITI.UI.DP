using System;
using System.Diagnostics;

namespace ITI.UI.DP.ShapreAdapter
{
    class GeometricShapeObjectAdapter : IShape
    {
        private IGeometricShape adaptee;

        public GeometricShapeObjectAdapter(IGeometricShape shape)
        {
            adaptee = shape;
        }
        public void Draw()
        {
            adaptee.DrawShape();
        }

        public void Resize()
        {
            Debug.WriteLine($"{Description()} can't be resized. Please create new one with required values");
        }

        public string Description()
        {
            return adaptee.GetType().Name + " object";
        }

        public bool IsHide()
        {
            return false;
        }
    }
}