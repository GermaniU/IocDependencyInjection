using System.Collections.Generic;
using System.Linq;

namespace First
{
    public class ValidationResult
    {
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool IsValid { get { return !ErrorMessage.Any(); } }
    }
}