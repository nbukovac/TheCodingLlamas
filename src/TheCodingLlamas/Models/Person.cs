using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheCodingLlamas.Models
{
    public class Person
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string College { get; set; }
        [Required]
        public string LinkedInUrl { get; set; }
        [Required]
        public string GithubUrl { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string RealTitle { get; set; }
        [Required]
        public string InternalTitle { get; set; }
        [Required]
        public string ProfilePicture { get; set; }

        public virtual List<Project> Projects { get; set; }
        public virtual List<Technology> Technologies { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, int year, string college, string linkedInUrl,
            string githubUrl, string email, string phoneNumber, string realTitle, string internalTitle,
            string profilePicture)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Year = year;
            College = college;
            LinkedInUrl = linkedInUrl;
            GithubUrl = githubUrl;
            Email = email;
            PhoneNumber = phoneNumber;
            RealTitle = realTitle;
            InternalTitle = internalTitle;
            ProfilePicture = profilePicture;
        }
    }
}
