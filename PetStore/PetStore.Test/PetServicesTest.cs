using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetStore.Services;

namespace PetStore.Test
{
    [TestClass]
    public class PetServicesTest
    {
        [TestMethod]
        public void PetService_OldEnoughToAdopt_Positive()
        {
            PetService petService = new PetService();
            Assert.IsTrue(petService.OldEnoughToAdopt(new DateTime(1990, 05, 01)));
        }

        [TestMethod]
        public void PetService_OldEnoughToAdopt_Negative()
        {
            PetService petService = new PetService();
            Assert.IsFalse(petService.OldEnoughToAdopt(new DateTime(2015, 05, 01)));
        }
    }
}
