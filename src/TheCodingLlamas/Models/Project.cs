using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCodingLlamas.Models
{
    public class Project
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public short Year { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        public string LiveDemoUrl { get; set; }
        public string GithubUrl { get; set; }
        [Required]
        public Guid PersonId { get; set; }


        public virtual Person Person { get; set; }
        public virtual List<Technology> UsedTechnologies { get; set; }

        public Project()
        {

        }

        public Project(string name, string description, short year, string pictureUrl,
            string liveDemoUrl, string githubUrl, Guid personId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Year = year;
            PictureUrl = pictureUrl;
            LiveDemoUrl = liveDemoUrl;
            GithubUrl = githubUrl;
            PersonId = personId;
        }
    }
}
