using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_pmarshall_ProgrammingChallenge1.Models
{
    public class Contact
    {
        // EF Core will make this value through the database
        // This is a primary key
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Enter a first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter a last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter a phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter an email")]
        public string Email { get; set; }

        // Optional organization information
        public string Organization { get; set; }

        // Date and time
        public DateTime DateAdded { get; set; }

        
        public Category Category { get; set; }

        [Range(1, 100000000, ErrorMessage= "Please select a category.")]
        public int CategoryId { get; set; }

        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
