using System.ComponentModel.DataAnnotations;

namespace ProductApp.Utility
{
    public class Positve : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if ((double) value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
