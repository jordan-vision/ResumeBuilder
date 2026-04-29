using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder;

public class Program
{
    const int BODYPADDING = 18;
    const int FONTSIZE = 11;
    public const int LEFTCOLUMNPADDING = 12;
    public const int LINEWIDTH = 1;
    const int NAMEFONTSIZE = 28;
    const int PAGEMARGIN = 36;
    public const int SECTIONTITLEFONTSIZE = 14;
    public const int SECTIONTITLEPADDING = 8;
    const float SIDEBARFACTOR = 1.0f / 3.0f;
    const int TITLEFONTSIZE = 12;
    const int TITLEPADDING = 12;
    
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
                page.DefaultTextStyle(x => x.FontSize(FONTSIZE));

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