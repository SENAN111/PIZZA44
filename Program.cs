using Pizzamizzadark.Models;
using Pizzamizzadark.Services;

namespace Pizzamizzadark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaService pizzaService= new PizzaService();
            pizzaService.CreatePizza("Margaritta", "XXXXX");
            PizzaService pizzaService1 = new PizzaService();
            List<Pizza> pizzas = pizzaService.GetAll();
            foreach (Pizza pizza in pizzas)
            {
                Console.WriteLine(pizza.Name);
            }
            IngerdientService ingerdientService= new IngerdientService();
            ingerdientService.CreateIngerident("Sous");
            IngerdientService ingerdientService1 = new IngerdientService();
            List<Ingerdient>ingerdients = ingerdientService1.GetAll();
            foreach(Ingerdient ingerdient in ingerdients)
            {
                Console.WriteLine(ingerdient.Name);
            }
            PizzaService pizzaService2 = new PizzaService();
            Pizza pizza1= pizzaService2.GetById(1);
            if(pizza1==null)
            {
                Console.WriteLine("bele pizza yoxdu");
            }
            Console.WriteLine(pizza1.Name);
            IngerdientService ingerdientService2= new IngerdientService();
            Ingerdient ingerdient1 = ingerdientService2.GetById(1);
            if(ingerdient1 == null)
            {
                Console.WriteLine("bele ingerdient yoxdu");

            }
            Console.WriteLine(ingerdient1.Name);
        }
    }
}