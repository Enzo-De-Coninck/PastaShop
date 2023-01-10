using System.ComponentModel.DataAnnotations;

namespace PastaShop
{
    public class VerledenAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return true;
            if (!(value is DateTime)) return false;
            return ((DateTime)value) < DateTime.Today;
        }
    }
}
