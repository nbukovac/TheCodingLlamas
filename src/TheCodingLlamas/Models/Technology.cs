using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCodingLlamas.Models
{
    public class Technology
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Technology()
        {

        }

        public Technology(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
