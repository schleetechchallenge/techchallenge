using Perficient.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Perficient.ViewModels
{
    public class AttendeeViewModel
    {
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        public int Client { get; set; }

        public IEnumerable<Client> Clients { get; set; }
    }
}