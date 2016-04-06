using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curlyzon.Model
{
    public class User
    {
        // Field UserId
        [Required(ErrorMessage = "User ID is required Field.")]
        [MinLength(2, ErrorMessage = "User ID must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "User ID must be no more than 50 characters.")]
        [RegularExpression(@"^[_a-zA-Z0-9@.-]*$", ErrorMessage = "User ID may contain only letters, numbers and following '_', '-', '.', '@' characters")]
        public string UserId { get; set; }
        
        // Field FirstName
        [Required(ErrorMessage = "First Name is required Field.")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "First Name must be no more than 50 characters.")]
        public string FirstName { get; set; }

        // Field MiddleName
        [MinLength(2, ErrorMessage = "Middle Name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Middle Name must be no more than 50 characters.")]
        public string MiddleName { get; set; }

        // Field LastName
        [Required(ErrorMessage = "Last Name is required Field.")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Last Name must be no more than 50 characters.")]
        public string LastName { get; set; }

        // Field CompanyName
        [MinLength(2, ErrorMessage = "Company Name must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Company Name must be no more than 50 characters.")]
        public string CompanyName { get; set; }

        // Field BusPhone
        [MinLength(2, ErrorMessage = "Business Phone must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Business Phone must be no more than 50 characters.")]
        public string BusPhone { get; set; }

        // Field MobilePhone
        [MinLength(2, ErrorMessage = "Mobile Phone must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Mobile Phone must be no more than 50 characters.")]
        public string MobilePhone { get; set; }

        // Field Email
        [Required(ErrorMessage = "Email is required Field.")]
        [MinLength(2, ErrorMessage = "Email must be at least 2 characters.")]
        [MaxLength(255, ErrorMessage = "Email must be no more than 255 characters.")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Email does not appear to be valid.")]
        public string Email { get; set; }

        // Field CreatedBy
        [MinLength(2, ErrorMessage = "Created By must be at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "Created By must be no more than 50 characters.")]
        public string CreatedBy { get; set; }
    }
}
