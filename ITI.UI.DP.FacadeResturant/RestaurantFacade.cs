namespace ITI.UI.DP.FacadeResturant
{
    class RestaurantFacade
    {
        private PizzaProvider pizzaProvider;
        private BreadProvider breadProvider;

        public RestaurantFacade()
        {
            this.pizzaProvider = new PizzaProvider();
            this.breadProvider = new BreadProvider();
        }

        public void GetVegPizza()
        {
            pizzaProvider.GetVegPizza();
        }

        public void GetNonVegPizzaWithBread()
        {
            breadProvider.GetGarlicBread();
            pizzaProvider.GetNonVegPizza();
        }

        public void GetCheesyGarlicBread()
        {
            breadProvider.GetGarlicBread();
        }
    }
}