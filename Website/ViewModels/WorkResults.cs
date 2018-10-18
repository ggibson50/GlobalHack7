using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Models;

namespace Website.ViewModels
{
    public class WorkResults
    {
        public Resume Resume { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<SkillCategory> SkillCategories { get; set; }
        public List<Guid> AquiredSkills { get; set; }
    }
}