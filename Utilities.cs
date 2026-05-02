using QuestPDF.Fluent;

namespace ResumeBuilder;

class Utilities
{
    public static void BulletPoint(ColumnDescriptor columnDescriptor, string content, string bulletPointGraphicPath = FormattingSettings.DEFAULTBULLETPOINT)
    {
        columnDescriptor.Item().PaddingVertical(FormattingSettings.BULLETPOINTSPACING)
            .Row(row =>
            {
                row.ConstantItem(FormattingSettings.FONTSIZE).Svg(bulletPointGraphicPath);
                row.RelativeItem().Text(" " + content);
            });
    }
}
