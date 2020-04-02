using System;
using System.Diagnostics;

namespace ITI.UI.DP.FacadeResturant
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(string.Format("{0}Client orders non veg pizza{0}\n", new  string('-',60)));
            var facadeRestaurant = new RestaurantFacade();
            facadeRestaurant.GetNonVegPizzaWithBread();
            
            Debug.WriteLine(string.Format("{0}Client orders veg pizza{0}\n", new  string('-',60)));
            facadeRestaurant.GetVegPizza();
            Debug.WriteLine(string.Format("{0}Client orders cheesy bread{0}\n", new  string('-',60)));
            facadeRestaurant.GetCheesyGarlicBread();
        }
    }
}
