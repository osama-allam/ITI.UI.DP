using System.Diagnostics;

namespace ITI.UI.DP.ShapreAdapter
{
    class Circle : IShape
    {
        public void Draw()
        {
            Debug.WriteLine("drawing circle");
        }

        public void Resize()
        {
            Debug.WriteLine("resizing circle");
        }

        public string Description()
        {
            return "circle object";
        }

        public bool IsHide()
        {
            Debug.WriteLine("hiding circle");
            return false;
        }
    }
}