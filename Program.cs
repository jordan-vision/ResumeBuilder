using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder;

public class Program
{
    const int BODYPADDING = 18; // Space between title and body in points
    const string FONTCOLOR = "575757"; // Hex code of text color unless otherwise specified
    const int FONTSIZE = 11; // Size of all text unless otherwise specified, in points
    public const int LEFTCOLUMNPADDING = 12; // Space between sections in the left column in points
    public const int LINEWIDTH = 1; // Width of borders in points
    const int NAMEFONTSIZE = 28; // Size of name in points
    const int PAGEMARGIN = 36; // Margin in points
    public const int SECTIONTITLEFONTSIZE = 14; // Sized of the name of a section in points
    public const int SECTIONTITLEPADDING = 8; // Space below the name of a section in points
    const float SIDEBARFACTOR = 1.0f / 3.0f; // Portion of the page that is the left column, between 0 and 1
    const int TITLEFONTSIZE = 12; // Size of job title in points
    const int TITLEPADDING = 12; // Space above and below name and job title block in points
    
    public static void Main()
    {
        Translations.SetupTranslations();
        QuestPDF.Settings.License = LicenseType.Evaluation;

        Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.Letter);
                page.Margin(PAGEMARGIN);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(FONTSIZE).FontColor(FONTCOLOR));

                page.Header().BorderHorizontal(LINEWIDTH)
                    .PaddingVertical(TITLEPADDING)
                    .Column(column =>
                    {
                        column.Item().Text("JORDAN BOSSOU")
                            .SemiBold().FontSize(NAMEFONTSIZE).AlignCenter();
                        column.Item().Text("TITLE")
                            .SemiBold().FontSize(TITLEFONTSIZE).AlignCenter();
                    });


                page.Content()
                    .PaddingTop(BODYPADDING)
                    .Row(x =>
                    {
                        x.RelativeItem(SIDEBARFACTOR).BorderRight(LINEWIDTH)
                            .Column(y =>
                            {
                                SectionManager.AddSection(y, SectionManager.Sections.CONTACT);
                                SectionManager.AddSection(y, SectionManager.Sections.EDUCATION);
                                SectionManager.AddSection(y, SectionManager.Sections.SKILLS);
                                SectionManager.AddSection(y, SectionManager.Sections.LANGUAGES);
                            });

                        x.RelativeItem(1 - SIDEBARFACTOR);
                    });
            });
        })
        .GeneratePdf("BlankResume.pdf");
    }
}