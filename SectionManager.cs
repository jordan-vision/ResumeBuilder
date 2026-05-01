using QuestPDF.Fluent;

namespace ResumeBuilder;

class SectionManager
{
    public enum Sections
    {
        CONTACT,
        EDUCATION,
        SKILLS,
        LANGUAGES
    }

    public static void AddSection(ColumnDescriptor column, Sections section)
    {
        column.Item().BorderBottom(Program.LINEWIDTH)
            .PaddingVertical(Program.LEFTCOLUMNPADDING).PaddingRight(Program.SECTIONPADDING)
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

                    default:
                        break;
                }

                // Section title
                col.Item().PaddingBottom(Program.SECTIONTITLEPADDING).Text(title)
                    .Bold().FontSize(Program.SECTIONTITLEFONTSIZE);

                // Add content to section
                sectionContent(col);
            });
    }

    public static void AddContactContent(ColumnDescriptor columnDescriptor)
    {
        // Phone number
        columnDescriptor.Item().Text("+1 438 866 2667"); 

        // Email adress
        columnDescriptor.Item().Text("jordanbossoulcb@gmail.com");

        // Itch link
        columnDescriptor.Item().Text(text =>
        {
            text.Hyperlink("jo-garden.itch.io", "http://jo-garden.itch.io").Underline();
        });

        // LinkedIn link
        columnDescriptor.Item().Text(text =>
        {
            text.Hyperlink("linkedin.com/in/jordan-bossou", "http://linkedin.com/in/jordan-bossou").Underline();
        });
    }

    public static void AddEducationContent(ColumnDescriptor columnDescriptor)
    {
        columnDescriptor.Item().Text("2022 - 2025").Bold();
        columnDescriptor.Item().Text(Translations.Get("concordia")).Bold();

        // Bulllet points
        columnDescriptor.Item().Text(Translations.Get("compsci"));
        columnDescriptor.Item().Text("GPA: 3.71");
        columnDescriptor.Item().Text(Translations.Get("deansList"));
    }

    public static void AddSkillsContent(ColumnDescriptor columnDescriptor)
    {

    }

    public static void AddLanguagesContent(ColumnDescriptor columnDescriptor)
    {
        // Bullet points
        if (ResumeSettings.CURRENTLANGUAGE == Translations.ENGLISH)
        {
            columnDescriptor.Item().Text(Translations.Get("english"));
            columnDescriptor.Item().Text(Translations.Get("french"));
        }
        else if (ResumeSettings.CURRENTLANGUAGE == Translations.FRENCH)
        {
            columnDescriptor.Item().Text(Translations.Get("french"));
            columnDescriptor.Item().Text(Translations.Get("english"));
        }
        
        columnDescriptor.Item().Text(Translations.Get("spanish"));
    }
}