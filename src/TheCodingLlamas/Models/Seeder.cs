﻿using System.Collections.Generic;

namespace TheCodingLlamas.Models
{
    public class Seeder
    {
        public static void SeedData(CodingLlamasDbContext dbContext)
        {
            // Technologies

            var technologies = new List<Technology>
            {
                new Technology("C#"),
                new Technology("Java"),
                new Technology(".*Script"),
                new Technology("Python"),
                new Technology("PHP"),
                new Technology("Bash"),
                new Technology("Swift")
            };

            dbContext.Technologies.AddRange(technologies);


            // Nikola Miličić

            var milicic = new Person("Nikola", "Miličić", 4, "Fakultet elektrotehnike i računarstva",
                "https://www.linkedin.com/in/nikola-miličić-33bab263/", "https://github.com/NMilicic",
                "", "",
                "Nikola is our C# master, but he can work magic with pretty much anything you throw his way.",
                "C# guru",
                "assets/images/milicic.jpg");

            var tempTech = new List<Technology>
            {
                technologies[0],
                technologies[2],
                technologies[5]
            };
            milicic.Technologies = tempTech;

            //milicic.Technologies.Add(technologies[0]);
            //milicic.Technologies.Add(technologies[2]);
            //milicic.Technologies.Add(technologies[5]);

            //milicic.Projects.Add();

            dbContext.Persons.Add(milicic);

            // Brigita Vrbanec

            var vrbanec = new Person("Brigita", "Vrbanec", 4, "Fakultet elektrotehnike i računarstva",
                "https://www.linkedin.com/in/bvrbanec/", "https://github.com/bvrbanec",
                "", "", "Brigita is the mastermind behind our projects but can also produce code if needed.",
                "Evil mastermind", "assets/images/vrbanec.jpg");
            vrbanec.Technologies.Add(technologies[0]);
            vrbanec.Technologies.Add(technologies[4]);
            vrbanec.Technologies.Add(technologies[5]);
            vrbanec.Technologies.Add(technologies[6]);

            dbContext.Persons.Add(vrbanec);


            // Nikola Bukovac


            var bukovac = new Person("Nikola", "Bukovac", 4,
                "Fakultet elektrotehnike i računarstva", "https://www.linkedin.com/in/nikola-bukovac-ab017b120/",
                "https://github.com/nbukovac", "nikola.bukovac@outlook.com",
                "+385912371969",
                "Nikola pulls classes and methods out of his sleeve and can easily turn any idea into code.",
                "Code monkey", "assets/images/bukovac.jpg");
            bukovac.Technologies.Add(technologies[0]);
            bukovac.Technologies.Add(technologies[1]);
            bukovac.Technologies.Add(technologies[3]);
            bukovac.Technologies.Add(technologies[5]);
            bukovac.Technologies.Add(technologies[6]);

            dbContext.Persons.Add(bukovac);


            //Projects

            var projects = new List<Project>
            {
                new Project("Lego Master", "", 2016, "assets/images/lego.jpg", "",
                    "https://github.com/NMilicic/MasterBuilders", milicic.Id)
            };

            dbContext.Projects.AddRange(projects);


            dbContext.SaveChanges();
        }
    }
}