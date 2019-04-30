using Perficient.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Perficient.ViewModels
{
    public class ClientViewModel
    {
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Street Address is Required")]
        [StringLength(255)]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [StringLength(255)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip Code is Required")]
        [RegularExpression(@"^[0-9]{5}(?:-[0-9]{4})?$", ErrorMessage = "Invalid Zip Code")]
        [Display(Name = "Zip Code (e.g., 12345-1234)")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        public IEnumerable<Attendee> Attendees { get; set; }
    }
}