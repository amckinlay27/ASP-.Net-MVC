using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Attributes
{
    public class NonNegativeAttribute : ValidationAttribute
    {
        public NonNegativeAttribute(): base("Number cannot be negative")
        {

        }

        public override bool IsValid(object value)
        {
            var number = (int)value;
            return number > 0;
        }
    }
}