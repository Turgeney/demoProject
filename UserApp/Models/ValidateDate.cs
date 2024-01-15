using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace UserApp.Models
{

    public class ValidateDate:ValidationAttribute
    { 
        protected override ValidationResult
        IsValid(object value, ValidationContext validationContext)
        {
            DateTime checkdate = Convert.ToDateTime(value);
            DateTime curdate = DateTime.Today;
            int bottom = curdate.Year - 100;
            int top = curdate.Year - 15;
            if (checkdate.Year >= bottom && checkdate.Year <= top) 
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult
                    ("Дата некорректна (старше 100 или младше 15");
            }
        }
    }
}
