using System.Diagnostics;

namespace ITI.UI.DP.FacadeResturant
{
    class BreadProvider : IBread
    {
        public void GetGarlicBread()
        {
            Debug.WriteLine("Getting garlic bread!");
        }

        public void GetGarlicCheesyBread()
        {
            GetCheese();
            Debug.WriteLine("Getting cheesy garlic bread!");
        }

        private void GetCheese()
        {
            Debug.WriteLine("Getting cheese!");
        }
    }
}