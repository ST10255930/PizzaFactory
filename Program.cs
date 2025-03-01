namespace PizzaFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();
            Console.WriteLine("Please enter your pizza: ");
            String selectedPizza = Console.ReadLine();
            IPizza pizza = factory.GetPizza(selectedPizza);
            Console.WriteLine("{0} base and {1} topings with {2} sauce",
                pizza.getBase(), pizza.getToping(),
                pizza.getSauce());

        }
    }
}
