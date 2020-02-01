using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Services
{
    public class PetService
    {
        private ApplicationDbContext context;

        public PetService()
        {
            this.context = new ApplicationDbContext();
        }

        public PetService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool OldEnoughToAdopt(DateTime age)
        {
            return (DateTime.Today.Year - age.Year) > 18;
        }
    }
}