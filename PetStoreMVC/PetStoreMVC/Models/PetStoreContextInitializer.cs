using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStoreMVC.Models
{
    //not for production just needed to Seed the Database
    //for demo purposes
    public class PetStoreContextInitializer : CreateDatabaseIfNotExists<PetStoreContext>
    {
        protected override void Seed(PetStoreContext context)
        {
            if (context.Database == null)
            {
                throw new Exception("Database is null");
            }

            if (context.Pets.Any())
            {
                return;
            }

            context.Pets.Add(
                new Pet()
                {
                    Name = "German Shepherd",
                    Description = "Cu vide legere usu. In tation meliore sed, mollis consectetuer est at, eum ne augue verterem necessitatibus. No nam esse tibique petentium, ad expetenda democritum cum. Percipitur accommodare eu est, mea putent regione epicuri in, falli ocurreret voluptaria ad sit.",
                    DateReceived = "2012/08/20",
                    Quantity = 3,
                    Price = 150.99

                }
            );

            context.Pets.Add(
                new Pet()
                {
                    Name = "Golden Retriever",
                    Description = "Cu vide legere usu. In tation meliore sed, mollis consectetuer est at, eum ne augue verterem necessitatibus. No nam esse tibique petentium, ad expetenda democritum cum. Percipitur accommodare eu est, mea putent regione epicuri in, falli ocurreret voluptaria ad sit.",
                    DateReceived = "2011/03/14",
                    Quantity = 2,
                    Price = 170.99

                }
            );

            context.Pets.Add(
                new Pet()
                {
                    Name = "Goldfish",
                    Description = "Cu vide legere usu. In tation meliore sed, mollis consectetuer est at, eum ne augue verterem necessitatibus. No nam esse tibique petentium, ad expetenda democritum cum. Percipitur accommodare eu est, mea putent regione epicuri in, falli ocurreret voluptaria ad sit.",
                    DateReceived = "2014/03/13",
                    Quantity = 3,
                    Price = 2.99

                }
            );

            context.Pets.Add(
                new Pet()
                {
                    Name = "Fat Cat",
                    Description = "Cu vide legere usu. In tation meliore sed, mollis consectetuer est at, eum ne augue verterem necessitatibus. No nam esse tibique petentium, ad expetenda democritum cum. Percipitur accommodare eu est, mea putent regione epicuri in, falli ocurreret voluptaria ad sit.",
                    DateReceived = "2001/01/01",
                    Quantity = 1,
                    Price = 0.99

                }
            );

            context.SaveChanges();
        }
    }
}