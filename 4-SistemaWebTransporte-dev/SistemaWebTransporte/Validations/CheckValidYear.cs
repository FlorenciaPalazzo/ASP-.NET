using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebTransporte.Validations
{
    public class CheckValidYear:ValidationAttribute
    {

        public CheckValidYear()
        {
            ErrorMessage="Error!";
        }
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 1998)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}