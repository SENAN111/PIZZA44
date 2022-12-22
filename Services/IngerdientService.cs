using Pizzamizzadark.Dal;
using Pizzamizzadark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzamizzadark.Services
{
    internal class IngerdientService
    {
        public void CreateIngerident(string name)
        {
            Ingerdient ingerdient = new Ingerdient
            {
                Name = name

            };
            using (AppDbContext context = new AppDbContext())
            {
                context.Ingerdients.Add(ingerdient);
                context.SaveChanges();
                Console.WriteLine("Created Ingerdient");
            }
        }

        public List<Ingerdient> GetAll()
        {
            List<Ingerdient> ingerdients;
            using (AppDbContext context = new AppDbContext())
            {
                ingerdients = context.Ingerdients.ToList();
            }
            return ingerdients;

        }
        public Ingerdient GetById(int id)
        {
            Ingerdient ingerdient;
            using (AppDbContext context = new AppDbContext())
            {
                ingerdient = context.Ingerdients.FirstOrDefault(p => p.Id == id);
            }
            return ingerdient;
        }
        public void DELETE(int id)
        {
            Ingerdient exsited;
            using (AppDbContext context = new AppDbContext())
            {
                exsited = context.Ingerdients.FirstOrDefault(p => p.Id == id);
                if (exsited != null)
                {
                    context.Ingerdients.Remove(exsited);
                    context.SaveChanges();
                    Console.WriteLine("Deleted Pizza");
                }
            }



        }

    }
}   
