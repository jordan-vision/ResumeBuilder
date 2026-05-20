using PdfSharp.Pdf.IO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder;
using System.Text;

public class Program
{   
    public static void Main()
    {
        Translations.SetupTranslations();
        var includePositon = ResumeSettings.TryGetPosition(out var jobPosition);
        var completeFileName = Path.Combine(ResumeSettings.PATH, "Resume Jordan Bossou " + ResumeSettings.FILENAMEEXTRA + ".pdf");

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
        .GeneratePdf(completeFileName);

        // Limit to 1 page
        using (var pdfDocument = PdfReader.Open(completeFileName, PdfDocumentOpenMode.Modify))
        {
            while (pdfDocument.PageCount > 1)
            {
                pdfDocument.Pages.RemoveAt(1);
            }
            pdfDocument.Save(completeFileName);
        }
    }
}