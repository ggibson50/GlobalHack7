namespace Website.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Website.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Website.Models.EmploymentDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Website.Models.EmploymentDatabase";
        }

        protected override void Seed(Website.Models.EmploymentDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Skill Type Table
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "Technical", Image = "technical.png"
            });
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "People", Image = "people.png"
            });
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "Mechanical", Image = "mechanical.png"
            });
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "Clerical", Image = "clerical.png"
            });
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "Language", Image = "language.png"
            });
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "Artist", Image = "artist.png"
            });
            context.SkillType.AddOrUpdate(new SkillType
            {
                Name = "Business", Image = "business.png"
            });
            
            // Skills Category Table
            context.SkillCategory.AddOrUpdate(new SkillCategory {
                SkillId = Guid.Parse("3f81e114-56d9-448b-b5ac-10be5d622c08"),
                SkillType = "Technical",
                SkillCategoryName = "Programming",
                Image = "technical.png"});
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("7eb172bb-ca8a-471a-8bc9-d9b200eeffe5"),
                SkillType = "Technical",
                SkillCategoryName = "Big Data Analysis",
                Image = "technical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("92b9c2f5-9b7b-440d-bcfd-f134e5480067"),
                SkillType = "Technical",
                SkillCategoryName = "Technical Writing",
                Image = "technical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("57ac34a4-5dfa-4189-9686-cc69101e321c"),
                SkillType = "Technical",
                SkillCategoryName = "Project Management",
                Image = "technical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("080ce108-c09a-4bdd-b548-e23f8194231a"),
                SkillType = "People",
                SkillCategoryName = "Training/Coach",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("c3b72784-a7bb-4314-ac4f-a46cfeb5c71d"),
                SkillType = "People",
                SkillCategoryName = "Customer Service",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("dfe3901e-4000-4bdc-9b64-97dd2553fdfe"),
                SkillType = "People",
                SkillCategoryName = "Management",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("5367f371-cffd-408c-b236-6311a1b2d591"),
                SkillType = "People",
                SkillCategoryName = "Caregiving",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("87298094-cd1f-468d-a7f4-c7384365ede3"),
                SkillType = "People",
                SkillCategoryName = "Entertainment",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("3985e94a-5e61-41e3-a075-b7e12b2f005d"),
                SkillType = "People",
                SkillCategoryName = "Counseling",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("80f95f66-3efd-464c-a958-1a8fdf6283c0"),
                SkillType = "People",
                SkillCategoryName = "Mediation",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("650d7ed9-38fc-4c3c-bea4-e735b607f7de"),
                SkillType = "People",
                SkillCategoryName = "Politics",
                Image = "people.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("878a0582-30cc-49e3-8ecb-650f5020425b"),
                SkillType = "Clerical",
                SkillCategoryName = "Accounting",
                Image = "clerical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("823d529c-4b19-4d0b-a067-7069b106063a"),
                SkillType = "Clerical",
                SkillCategoryName = "Data Entry",
                Image = "clerical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("e4541a1d-ca22-4b7a-99ef-87a56b853442"),
                SkillType = "Artistic",
                SkillCategoryName = "Marketing",
                Image = "artist.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("62306a6f-2db5-49cd-862c-96a690a6691e"),
                SkillType = "Artistic",
                SkillCategoryName = "Production",
                Image = "artist.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("65d53d0c-a791-45a1-9157-522e32e127b7"),
                SkillType = "Mechanical",
                SkillCategoryName = "Auto",
                Image = "mechanical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("c52d5838-ad98-4e3a-930e-6de1be63ffbc"),
                SkillType = "Mechanical",
                SkillCategoryName = "Engineering",
                Image = "mechanical.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("1a5b1592-3061-46cc-bdc9-4045ce944e31"),
                SkillType = "Language",
                SkillCategoryName = "Translation",
                Image = "language.png"
            });
            context.SkillCategory.AddOrUpdate(new SkillCategory
            {
                SkillId = Guid.Parse("6a977cf5-990a-4099-a67b-683b99443116"),
                SkillType = "Entrepreneurial",
                SkillCategoryName = "Administration",
                Image = "business.png"
            });

            // Job Skills Table
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("dcbb4309-f5ae-415e-80fb-dbc9b2df51ff"),
                SkillType = "Technical",
                SkillCategory = "Programming",
                JobSkillName = "Applications Programming"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("8098c60d-cff3-46ff-a567-041624900db6"),
                SkillType = "Technical",
                SkillCategory = "Big Data Analysis",
                JobSkillName = "Database Design"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("0c0ac864-95c1-463b-aa60-ea5db37d6c46"),
                SkillType = "Technical",
                SkillCategory = "Project Management",
                JobSkillName = "Engineering"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("a83dba04-a29e-4599-84af-949cde5386ee"),
                SkillType = "Technical",
                SkillCategory = "Technical Writing",
                JobSkillName = "Research"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("a36b3d85-75bf-4db0-aec1-4efbf8164e1f"),
                SkillType = "People",
                SkillCategory = "Coaching/Training",
                JobSkillName = "Human Resource Specialist"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("c69d38d3-f695-488c-b7d9-0d2020072c50"),
                SkillType = "People",
                SkillCategory = "Management",
                JobSkillName = "Sales Manager"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("7d8a7591-259f-40a9-b4be-3fb636c0601b"),
                SkillType = "People",
                SkillCategory = "Caregiving",
                JobSkillName = "Care Provider"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("7c3da444-50dd-458e-ba45-c02b7180497e"),
                SkillType = "People",
                SkillCategory = "Entertainment",
                JobSkillName = "Social media"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("1b6c733a-0c50-4899-b095-647729bfa941"),
                SkillType = "People",
                SkillCategory = "Customer Service",
                JobSkillName = "Representative"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("77c7ed18-3067-40a2-84aa-a012c2572379"),
                SkillType = "People",
                SkillCategory = "Counseling",
                JobSkillName = "Mentor"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("d0b433cf-6e82-40a6-a88e-6e693379b122"),
                SkillType = "People",
                SkillCategory = "Mediation",
                JobSkillName = "Event Organizer"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("ee1066eb-9593-433a-aff5-ee9ce597351f"),
                SkillType = "People",
                SkillCategory = "Politics",
                JobSkillName = "Politician"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("7d7b658f-fabb-4a0d-9e67-73bb62237eff"),
                SkillType = "Clerical",
                SkillCategory = "Accounting",
                JobSkillName = "Finance Advisor"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("4260a61f-e557-4111-8de4-51375c9844f3"),
                SkillType = "Clerical",
                SkillCategory = "Data Entry",
                JobSkillName = "Data Clerk"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("3a079c94-cfa6-4866-98f7-fe4431e00430"),
                SkillType = "Artistic",
                SkillCategory = "Marketing",
                JobSkillName = "Ad Marketing"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("c581635c-957e-49c1-9a7b-c1bb1bcd3405"),
                SkillType = "Artistic",
                SkillCategory = "Production",
                JobSkillName = "Graphic Artist"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("c49a4efd-a404-4803-a2f0-358aefdcaa0b"),
                SkillType = "Mechanical",
                SkillCategory = "Auto",
                JobSkillName = "Mechanic"
            });
            context.JobSkill.AddOrUpdate(new JobSkill
            {
                JobSkillId = Guid.Parse("a06363a0-b386-41d0-9f9f-9809ccc8f98b"),
                SkillType = "Mechanical",
                SkillCategory = "Engineering",
                JobSkillName = "Civil Engineering"
            });
             // Industry Table
            context.Industries.AddOrUpdate(new Industry
            {
                IndustryId = Guid.Parse("c2681640-cae7-425f-a48c-f2e7a1e2b3b9"),
                IndustryName = "Automotive"
            });

            context.Industries.AddOrUpdate(new Industry
            {
                IndustryId = Guid.Parse("fc692308-1567-4ce7-bae1-68ee3b768303"),
                IndustryName = "Technology"
            });

            context.Industries.AddOrUpdate(new Industry
            {
                IndustryId = Guid.Parse("19f66291-8eb5-49b5-b2dd-ecf208b3bcec"),
                IndustryName = "Food"
            });

            // Ethnicity Table
            context.Ethnicities.AddOrUpdate(new Ethnicity
            {
                EthnicityId = Guid.Parse("766bb369-67ae-4a07-872b-6bbe9357c436"),
                EthnicityName = "Asian"
            });

            context.Ethnicities.AddOrUpdate(new Ethnicity
            {
                EthnicityId = Guid.Parse("ed7de62d-5c0b-43fc-b44a-b9ade6b8d78f"),
                EthnicityName = "Mexican"
            });

            context.Ethnicities.AddOrUpdate(new Ethnicity
            {
                EthnicityId = Guid.Parse("73bf3014-7c41-496e-bdcb-e19f6e634a89"),
                EthnicityName = "White"
            });

            // Language Table
            context.Languages.AddOrUpdate(new Language
            {
                LanguageCode = "en",
                EnglishLanguageName = "English",
                NativeLanguageName = "English"
            });

            context.Languages.AddOrUpdate(new Language
            {
                LanguageCode = "de",
                EnglishLanguageName = "German",
                NativeLanguageName = "Deutsch"
            });

            context.Languages.AddOrUpdate(new Language
            {
                LanguageCode = "ru",
                EnglishLanguageName = "Russian",
                NativeLanguageName = "русский язык"
            });
        }
    }
}
