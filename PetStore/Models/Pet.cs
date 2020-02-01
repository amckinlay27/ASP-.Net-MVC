using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetStore.Attributes;

namespace PetStore.Models
{
    public class Pet
    {

        public int ID { get; set; }
        public string Breed { get; set; }

        [NoDigitsAttribute]
        public string Name { get; set; }
        public bool isMale { get; set; }

        [NonNegativeAttribute]
        public int Age { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}