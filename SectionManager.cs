using QuestPDF.Fluent;

namespace ResumeBuilder;

class SectionManager
{
    public enum Sections
    {
        CONTACT,
        EDUCATION,
        SKILLS,
        LANGUAGES,
        INTERESTS,
        WORKEXPERIENCE,
        EXTRACURRICULAR
    }

    public static void AddSection(ColumnDescriptor column, Sections section)
    {
        column.Item().BorderBottom(FormattingSettings.LINEWIDTH)
            .PaddingVertical(FormattingSettings.SECTIONPADDING).PaddingHorizontal(FormattingSettings.MIDDLEPADDING)
            .Column(col =>
            {
                string title = "";
                Action<ColumnDescriptor> sectionContent = (c) => { };

                // Get proper section title and content
                switch (section)
                {
                    case Sections.CONTACT:
                        title = Translations.Get("contactTitle");
                        sectionContent = c => AddContactContent(c);
                        break;

                    case Sections.EDUCATION:
                        title = Translations.Get("educationTitle");
                        sectionContent = c => AddEducationContent(c);
                        break;

                    case Sections.SKILLS:
                        title = Translations.Get("skillsTitle");
                        sectionContent = c => AddSkillsContent(c);
                        break;

                    case Sections.LANGUAGES:
                        title = Translations.Get("languagesTitle");
                        sectionContent = c => AddLanguagesContent(c);
                        break;

                    case Sections.INTERESTS:
                        title = Translations.Get("interestsTitle");
                        sectionContent = c => AddInterestsContent(c);
                        break;

                    case Sections.WORKEXPERIENCE:
                        title = Translations.Get("workExperienceTitle");
                        sectionContent = c => AddExperienceContent(c, JobManager.WorkExperience);
                        break;

                    case Sections.EXTRACURRICULAR:
                        title = Translations.Get("extracurricularTitle");
                        sectionContent = c => AddExperienceContent(c, JobManager.Extracurricular);
                        break;

                    default:
                        break;
                }

                // Section title
                col.Item().PaddingBottom(FormattingSettings.SECTIONTITLEPADDING).Text(title)
                    .Bold().FontSize(FormattingSettings.SECTIONTITLEFONTSIZE);

                // Add content to section
                sectionContent(col);
            });
    }

    public static void AddContactContent(ColumnDescriptor columnDescriptor)
    {
        columnDescriptor.Item().Row(row =>
        {
            // Phone number
            Utilities.BulletPoint(row, "+1 438 866 2667", "Resources/phone-icon.svg");

            // Email adress
            Utilities.BulletPoint(row, "jordanbossoulcb@gmail.com", "Resources/email-icon.svg");
        });

        columnDescriptor.Item().Row(row =>
        {
            // Itch link
            row.RelativeItem().Row(subRow =>
            {
                subRow.ConstantItem(FormattingSettings.FONTSIZE).Svg("Resources/website-icon.svg");
                subRow.AutoItem().Text(text =>
                {
                    text.Span(" ");
                    text.Hyperlink("jo-garden.itch.io", "http://jo-garden.itch.io").Underline();
                });
            });

            // LinkedIn link
            row.RelativeItem().Row(subRow =>
            {
                subRow.ConstantItem(FormattingSettings.FONTSIZE).Svg("Resources/linkedin-icon.svg");
                subRow.AutoItem().Text(text =>
                {
                    text.Span(" ");
                    text.Hyperlink("linkedin.com/in/jordan-bossou", "http://linkedin.com/in/jordan-bossou").Underline();
                });
            });
        });
    }

    public static void AddEducationContent(ColumnDescriptor columnDescriptor)
    {
        columnDescriptor.Item().Text("2022 - 2025").Bold();
        columnDescriptor.Item().Text(Translations.Get("concordia")).Bold();

        // Bulllet points
        Utilities.BulletPoint(columnDescriptor, $"{Translations.Get("compsci")}, {Translations.Get("distinction")}");
        Utilities.BulletPoint(columnDescriptor, "GPA: 3.71");
        Utilities.BulletPoint(columnDescriptor, Translations.Get("deansList"));
    }

    public static void AddSkillsContent(ColumnDescriptor columnDescriptor)
    {
        // Add hard skills
        var hardSkillsTranslated = SkillsAndInterests.RELEVANTHARDSKILLS.Select(skill => Translations.Get(skill));
        var hardSkills = String.Join(", ", hardSkillsTranslated);
        if (hardSkills.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, hardSkills);
        }

        // Add programming languages as a single bullet point
        var languages = String.Join(", ", SkillsAndInterests.RELEVANTLANGUAGES);
        if (languages.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, languages);
        }

        // Add frameworks and libraries as a single bullet point
        var frameworks = String.Join(", ", SkillsAndInterests.RELEVANTFRAMEWORKS);
        if (frameworks.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, frameworks);
        }

        // Add IDEs as a single bullet point
        var ides = String.Join(", ", SkillsAndInterests.RELEVANTIDES);
        if (ides.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, ides);
        }

        // Add game engines as a single bullet point
        var gameEngines = String.Join(", ", SkillsAndInterests.RELEVANTGAMEENGINES);
        if (gameEngines.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, gameEngines);
        }

        // Add OSes as a single bullet point
        var os = String.Join(", ", SkillsAndInterests.RELEVANTOS);
        if (os.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, os);
        }

        // Add terminals as a single bullet point
        var terminals = String.Join(", ", SkillsAndInterests.RELEVANTTERMINALS);
        if (terminals.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, terminals);
        }

        // Add other software as a single bullet point
        var software = String.Join(", ", SkillsAndInterests.RELEVANTSOFTWARE);
        if (software.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, software);
        }

        // Add soft skills
        var softSkillsTranslated = SkillsAndInterests.RELEVANTSOFTSKILLS.Select(skill => Translations.Get(skill));
        var softSkills = String.Join(", ", softSkillsTranslated);
        if (softSkills.Length != 0)
        {
            Utilities.BulletPoint(columnDescriptor, softSkills);
        }
    }

    public static void AddLanguagesContent(ColumnDescriptor columnDescriptor)
    {
        // Bullet points
        if (ResumeSettings.CURRENTLANGUAGE == Translations.ENGLISH)
        {
            Utilities.BulletPoint(columnDescriptor, Translations.Get("english"));
            Utilities.BulletPoint(columnDescriptor, Translations.Get("french"));
        }
        else if (ResumeSettings.CURRENTLANGUAGE == Translations.FRENCH)
        {
            Utilities.BulletPoint(columnDescriptor, Translations.Get("french"));
            Utilities.BulletPoint(columnDescriptor, Translations.Get("english"));
        }

        Utilities.BulletPoint(columnDescriptor, Translations.Get("spanish"));
    }

    public static void AddInterestsContent(ColumnDescriptor columnDescriptor)
    {
        // Add interests
        foreach (var interest in SkillsAndInterests.RELEVANTINTERESTS)
        {
            Utilities.BulletPoint(columnDescriptor, Translations.Get(interest));
        }
    }

    public static void AddExperienceContent(ColumnDescriptor columnDescriptor, List<Job> experience)
    {
        // Get all jobs
        JobManager.SetupJobs();
        JobManager.SetupExtraCurricular();

        var jobList = experience.Where(x => x.Include);
        
        if (ResumeSettings.SORTINGMETHOD == ResumeSettings.SortingMethod.Start) {
            jobList = jobList.OrderByDescending(x => x.Positions.Last().StartMonth.Item1)
            .OrderByDescending(x => x.Positions.Last().StartMonth.Item2);
        }

        else if (ResumeSettings.SORTINGMETHOD == ResumeSettings.SortingMethod.End)
        {
            jobList = jobList.OrderByDescending(x => x.Positions.First().EndMonth.Item1)
            .OrderByDescending(x => x.Positions.First().EndMonth.Item2);
        }

        foreach (var job in jobList)
        {
            columnDescriptor.Item().Text(Translations.Get(job.Company)).Bold(); // Company name
            foreach (var position in job.Positions)
            {
                // Each position
                columnDescriptor.Item().PaddingLeft(FormattingSettings.TAB).Row(row =>
                {
                    // Position and start/end
                    row.AutoItem().Text(Translations.Get(position.Title));
                    row.RelativeItem().Text(Translations.Dates(position.StartMonth, position.EndMonth)).AlignRight();

                    // Achievements, in bullet points
                    foreach (var accomplishment in position.Accomplishments)
                    {
                        Utilities.BulletPoint(columnDescriptor, Translations.Get(accomplishment), 1);
                    }
                });
            }
            // Add a bit of space after job
            columnDescriptor.Item().PaddingBottom(FormattingSettings.JOBPADDING);
        }
    }
}