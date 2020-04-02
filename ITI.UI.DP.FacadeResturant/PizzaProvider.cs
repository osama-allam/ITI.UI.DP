using System.Diagnostics;

namespace ITI.UI.DP.FacadeResturant
{
    class PizzaProvider : IPizza
    {
        public void GetVegPizza()
        {
            Debug.WriteLine("Getting veg pizza");
        }

        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Debug.WriteLine("Getting non veg pizza");
        }

        private void GetNonVegToppings()
        {
            Debug.WriteLine("Getting non veg toppings");
        }
    }
}