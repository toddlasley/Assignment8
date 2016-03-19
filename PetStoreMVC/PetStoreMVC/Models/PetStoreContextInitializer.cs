using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStoreMVC.Models
{
    //not for production just needed to Seed the Database
    //for demo purposes
    public class PetStoreContextInitializer : DropCreateDatabaseAlways<PetStoreContext>
    {
        protected override void Seed(PetStoreContext context)
        {
            context.Pets.Add(
                new Pet()
                {
                    Description = "German Shepherd",
                    DateReceived = "2012/08/20",
                    Quantity = 3,
                    Price = 150.99

                }
            );

            context.Pets.Add(
                new Pet()
                {
                    Description = "Golden Retriever",
                    DateReceived = "2011/03/14",
                    Quantity = 2,
                    Price = 170.99

                }
            );

            context.Pets.Add(
                new Pet()
                {
                    Description = "Goldfish",
                    DateReceived = "2014/03/13",
                    Quantity = 3,
                    Price = 2.99

                }
            );

            context.Pets.Add(
                new Pet()
                {
                    Description = "Fat Cat",
                    DateReceived = "2001/01/01",
                    Quantity = 1,
                    Price = 0.99

                }
            );

            context.SaveChanges();
        }
    }
}