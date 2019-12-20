using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LUniversityNC19.Validation
{
    public class CheckStreetNrAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //Exception
            //var input = (string)value;
            //Null
            //var input2 = value as string;

            if(value is string input)
            {
                var lastWord = input.Split().Last();
                return int.TryParse(lastWord, out _);
            }

            return false;
        }
    }
}
