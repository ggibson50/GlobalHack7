using System.Data.Entity;

namespace Website.Models
{
    public class EmploymentDatabase : DbContext
    {
        public DbSet<SkillType> SkillType { get; set; }
        public DbSet<SkillCategory> SkillCategory { get; set; }
        public DbSet<JobSkill> JobSkill { get; set; }
        public DbSet<BusinessProfile> BusinessProfiles { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Ethnicity> Ethnicities { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ResumeSkill> ResumeSkills { get; set; }
    }
}