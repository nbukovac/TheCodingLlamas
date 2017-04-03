using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheCodingLlamas.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, int year, string college, string linkedInUrl,
            string githubUrl, string email, string phoneNumber, string description, string internalTitle,
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
            Description = description;
            InternalTitle = internalTitle;
            ProfilePicture = profilePicture;

            Projects = new List<Project>();
            Technologies = new List<Technology>();
        }

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
        public string Description { get; set; }

        [Required]
        public string InternalTitle { get; set; }

        [Required]
        public string ProfilePicture { get; set; }

        public virtual List<Project> Projects { get; set; }
        public virtual List<Technology> Technologies { get; set; }
    }
}