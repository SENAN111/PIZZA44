using Microsoft.Identity.Client;
using Pizzamizzadark.Dal;
using Pizzamizzadark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzamizzadark.Services
{
    internal class PizzaService
    {
        public void CreatePizza(string name , string image)
        {
            Pizza pizza = new Pizza
            {
                Name = name,
                Image = image
            };
           using (AppDbContext context = new AppDbContext())
            {
                context.Pizzas.Add(pizza);
                context.SaveChanges();
                Console.WriteLine("Created Pizza");
            }
          
        }
        public List<Pizza> GetAll() 
        {
            List<Pizza> pizzas;
            using (AppDbContext context = new AppDbContext())
            {
                pizzas=context.Pizzas.ToList();
            }
            return pizzas;

        }
        public Pizza GetById(int id)
        {
            Pizza pizza;
            using (AppDbContext context = new AppDbContext())
            {
                pizza = context.Pizzas.FirstOrDefault(p => p.Id == id);
            }
            return pizza;
        }
        public void DELETE(int id)
        {
            Pizza exsited;
            using (AppDbContext context = new AppDbContext())
            {
                exsited = context.Pizzas.FirstOrDefault(p => p.Id == id);
                if(exsited!= null)
                {
                    context.Pizzas.Remove(exsited);
                    context.SaveChanges() ;
                    Console.WriteLine("Deleted Pizza");
                }
            }
           


        }
    }
}
