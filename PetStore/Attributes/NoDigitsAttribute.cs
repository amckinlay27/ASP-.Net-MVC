using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetStore.Attributes
{
    public class NoDigitsAttribute : ValidationAttribute
    {
        public NoDigitsAttribute() : base("No numbers allowed!")
        {

        }

        public override bool IsValid(object value)
        {
            var content = (string)value;

            foreach (char c in content)
            {
                var cType = c.GetType();
                if(cType.IsInstanceOfType(1))
                {
                    return false;
                }
            }

            return true;
        }
    }
}