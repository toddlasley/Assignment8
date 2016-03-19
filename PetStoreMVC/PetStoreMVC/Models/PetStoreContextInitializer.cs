using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStoreMVC.Models
{
    //not for production just needed to Seed the Database
    public class PetStoreContextInitializer : DropCreateDatabaseAlways<PetStoreContext>
    {
        protected override void Seed(PetStoreContext context)
        {
            context.Pets.Add(
                new Pet()
                {
                    Description = "German Shepherd",
                    DateReceived = new DateTime(03/14/05),
                    Quantity = 3,
                    Price = 150.99

                }
            );
        }
    }
}