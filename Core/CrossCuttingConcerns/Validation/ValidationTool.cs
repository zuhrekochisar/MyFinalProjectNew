using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
   public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            //ProductValidator productValidator = new ProductValidator();  // Gerek kalmadı.(IValidator validator) bunu yazdığımız için.
            var result = validator.Validate(context);  //Sonuç geçerli değilse.
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
