using System;
using System.ComponentModel.DataAnnotations;

namespace TheCodingLlamas.Models
{
    public class Technology
    {
        public Technology()
        {
        }

        public Technology(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}