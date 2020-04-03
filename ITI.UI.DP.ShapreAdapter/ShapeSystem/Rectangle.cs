using System.Diagnostics;

namespace ITI.UI.DP.ShapreAdapter
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Debug.WriteLine("drawing Rectangle");
        }

        public void Resize()
        {
            Debug.WriteLine("resizing Rectangle");
        }

        public string Description()
        {
            return "Rectangle object";
        }

        public bool IsHide()
        {
            Debug.WriteLine("hiding Rectangle");
            return false;
        }
    }
}