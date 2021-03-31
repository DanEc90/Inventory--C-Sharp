using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Helps
{
    public class DataValidation
    {
        private readonly ValidationContext context;
        private readonly List<ValidationResult> results;
        private readonly bool valid;
        private string message;

        public DataValidation(object instance)
        {
            context = new ValidationContext(instance);
            results = new List<ValidationResult>();
            valid = Validator.TryValidateObject(instance, context, results, true);
        }

        public bool Validate()
        {
            if(valid == false)
            {
                foreach(ValidationResult item in results)
                {
                    message += item.ErrorMessage + "\n"; 
                }
                System.Windows.Forms.MessageBox.Show(message);
            }
            return valid;
        }
    }
}
