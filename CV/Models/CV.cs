using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace CV.Models
{
    public class CVContext : DbContext
    {

        public PersonalData PersonalData {get;set;}
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Education> Educations { get; set; }
        public ProjectSkill ProjectSkill { get; set; }

    }


    
}