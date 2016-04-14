using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStoreMVC.Models
{
    public class PetStoreContext : DbContext
    {

        public PetStoreContext() : base("AzureSQLConnection")
        {
            Database.SetInitializer<PetStoreContext>(new DropCreateDatabaseIfModelChanges<PetStoreContext>());
        }

        public DbSet<Pet> Pets { get; set; }
    }
}