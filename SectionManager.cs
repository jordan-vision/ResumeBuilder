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
        column.Item().BorderBottom(Program.LINEWIDTH).PaddingVertical(Program.LEFTCOLUMNPADDING)
            .Column(col =>
            {
                string title = "";
                Action<ColumnDescriptor> sectionContent = (c) => { };

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

                col.Item().PaddingBottom(Program.SECTIONTITLEPADDING).Text(title)
                    .Bold().FontSize(Program.SECTIONTITLEFONTSIZE);

                sectionContent(col);
            });
    }

    public static void AddContactContent(ColumnDescriptor columnDescriptor)
    {
        columnDescriptor.Item().Text("+1 438 866 2667"); 
        columnDescriptor.Item().Text("jordanbossoulcb@gmail.com");
        columnDescriptor.Item().Text(text =>
        {
            text.Hyperlink("jo-garden.itch.io", "http://jo-garden.itch.io").Underline();
        });
        columnDescriptor.Item().Text(text =>
        {
            text.Hyperlink("linkedin.com/in/jordan-bossou", "http://linkedin.com/in/jordan-bossou").Underline();
        });
    }

    public static void AddEducationContent(ColumnDescriptor rowDescriptor)
    {

    }

    public static void AddSkillsContent(ColumnDescriptor rowDescriptor)
    {

    }

    public static void AddLanguagesContent(ColumnDescriptor rowDescriptor)
    {

    }
}