using System;
using System.ComponentModel.DataAnnotations;

namespace Perficient.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public Client Client { get; set; }
    }
}