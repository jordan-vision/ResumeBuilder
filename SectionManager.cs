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
        WORKEXPERIENCE,
        VOLUNTEERING
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

                    case Sections.WORKEXPERIENCE:
                        title = Translations.Get("workExperienceTitle");
                        sectionContent = c => AddWorkExperienceContent(c);
                        break;

                    case Sections.VOLUNTEERING:
                        title = Translations.Get("volunteeringTitle");
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
        // Phone number
        Utilities.BulletPoint(columnDescriptor, "+1 438 866 2667", "Resources/phone-icon.svg");

        // Email adress
        Utilities.BulletPoint(columnDescriptor, "jordanbossoulcb@gmail.com", "Resources/email-icon.svg");

        // Itch link
        columnDescriptor.Item().Row(row =>
        {
            row.ConstantItem(FormattingSettings.FONTSIZE).Svg("Resources/website-icon.svg");
            row.RelativeItem().Text(text =>
            {
                text.Span(" ");
                text.Hyperlink("jo-garden.itch.io", "http://jo-garden.itch.io").Underline();
            });
        });

        // LinkedIn link
        columnDescriptor.Item().Row(row =>
        {
            row.ConstantItem(FormattingSettings.FONTSIZE).Svg("Resources/linkedin-icon.svg");
            row.RelativeItem().Text(text =>
            {
                text.Span(" ");
                text.Hyperlink("linkedin.com/in/jordan-bossou", "http://linkedin.com/in/jordan-bossou").Underline();
            });
        });
    }

    public static void AddEducationContent(ColumnDescriptor columnDescriptor)
    {
        columnDescriptor.Item().Text("2022 - 2025").Bold();
        columnDescriptor.Item().Text(Translations.Get("concordia")).Bold();

        // Bulllet points
        Utilities.BulletPoint(columnDescriptor, Translations.Get("compsci"));
        Utilities.BulletPoint(columnDescriptor, "GPA: 3.71");
        Utilities.BulletPoint(columnDescriptor, Translations.Get("deansList"));
    }

    public static void AddSkillsContent(ColumnDescriptor columnDescriptor)
    {
        // Add hard skills
        foreach (var skill in Skills.RELEVANTHARDSKILLS)
        {
            Utilities.BulletPoint(columnDescriptor, Translations.Get(skill));
        }

        // Add programming languages as a single bullet point
        var languages = String.Join(", ", Skills.RELEVANTLANGUAGES);
        if (languages != null)
        {
            Utilities.BulletPoint(columnDescriptor, languages);
        }

        // Add frameworks and libraries as a single bullet point
        var frameworks = String.Join(", ", Skills.RELEVANTFRAMEWORKS);
        if (frameworks != null)
        {
            Utilities.BulletPoint(columnDescriptor, frameworks);
        }

        // Add IDEs as a single bullet point
        var ides = String.Join(", ", Skills.RELEVANTIDES);
        if (ides != null)
        {
            Utilities.BulletPoint(columnDescriptor, ides);
        }

        // Add game engines as a single bullet point
        var gameEngines = String.Join(", ", Skills.RELEVANTGAMEENGINES);
        if (gameEngines != null)
        {
            Utilities.BulletPoint(columnDescriptor, gameEngines);
        }

        // Add OSes as a single bullet point
        var os = String.Join(", ", Skills.RELEVANTOS);
        if (os != null)
        {
            Utilities.BulletPoint(columnDescriptor, os);
        }

        // Add other software as a single bullet point
        var software = String.Join(", ", Skills.RELEVANTSOFTWARE);
        if (software != null)
        {
            Utilities.BulletPoint(columnDescriptor, software);
        }

        // Add soft skills
        foreach (var skill in Skills.RELEVANTSOFTSKILLS)
        {
            Utilities.BulletPoint(columnDescriptor, Translations.Get(skill));
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

    public static void AddWorkExperienceContent(ColumnDescriptor columnDescriptor)
    {
        // Get all jobs
        JobManager.SetupJobs();

        foreach (var job in JobManager.WorkExperience)
        {
            // Skip the ones I don't wish to include
            if (!job.Include)
            {
                continue;
            }

            columnDescriptor.Item().Text(Translations.Get(job.Company)).Bold(); // Company name
            columnDescriptor.Item().Row(row =>
            {
                foreach (var position in job.Positions)
                {
                    // Position and start/end
                    row.RelativeItem().Text(Translations.Get(position.Title));
                    row.RelativeItem().Text(Translations.Dates(position.StartMonth, position.EndMonth)).AlignRight();

                    // Move on to the next job if I don't wish to include achievements
                    if (!job.ShowDetails)
                    {
                        continue;
                    }

                    // Achievements, in bullet points
                    foreach (var accomplishment in position.Accomplishments)
                    {
                        Utilities.BulletPoint(columnDescriptor, Translations.Get(accomplishment));
                    }
                }
            });
            // Add a bit of space after job
            columnDescriptor.Item().PaddingBottom(FormattingSettings.JOBPADDING);
        }
    }
}