using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder;

public class Program
{   
    public static void Main()
    {
        Translations.SetupTranslations();
        var includePositon = ResumeSettings.TryGetPosition(out var jobPosition);

        QuestPDF.Settings.License = LicenseType.Evaluation;

        Document.Create(container =>
        {
            container.Page(page =>
            {
                // Page style
                page.Size(PageSizes.Letter);
                page.Margin(FormattingSettings.PAGEMARGIN);
                page.PageColor(Colors.White);

                // Text style
                page.DefaultTextStyle(x => x.FontSize(FormattingSettings.FONTSIZE).FontColor(FormattingSettings.FONTCOLOR));

                // Header
                page.Header().BorderHorizontal(FormattingSettings.LINEWIDTH)
                    .PaddingVertical(FormattingSettings.TITLEPADDING)
                    .Column(column =>
                    {
                        // My name
                        column.Item().Text("JORDAN BOSSOU")
                            .SemiBold().FontSize(FormattingSettings.NAMEFONTSIZE).AlignCenter();

                        if (!includePositon)
                        {
                            return;
                        }

                        // Use job title depending on language
                        column.Item().Text(jobPosition)
                            .SemiBold().FontSize(FormattingSettings.TITLEFONTSIZE).AlignCenter();
                    });


                // Page content
                page.Content()
                    .PaddingTop(FormattingSettings.BODYPADDING)
                    .Row(x =>
                    {
                        // Left column sections
                        x.RelativeItem(FormattingSettings.SIDEBARFACTOR).BorderRight(FormattingSettings.LINEWIDTH)
                            .Column(y =>
                            {
                                SectionManager.AddSection(y, SectionManager.Sections.CONTACT);
                                SectionManager.AddSection(y, SectionManager.Sections.EDUCATION);
                                SectionManager.AddSection(y, SectionManager.Sections.SKILLS);
                                SectionManager.AddSection(y, SectionManager.Sections.LANGUAGES);
                            });

                        // Right column sections
                        x.RelativeItem(1 - FormattingSettings.SIDEBARFACTOR)
                            .Column(y => 
                            {
                                SectionManager.AddSection(y, SectionManager.Sections.WORKEXPERIENCE);
                                SectionManager.AddSection(y, SectionManager.Sections.VOLUNTEERING);
                            });
                    });
            });
        })
        .GeneratePdf("Draft.pdf");
    }
}