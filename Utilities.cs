using QuestPDF.Fluent;

namespace ResumeBuilder;

class Utilities
{
    public static void BulletPoint(ColumnDescriptor columnDescriptor, string content, int indent = 0, string bulletPointGraphicPath = FormattingSettings.DEFAULTBULLETPOINT)
    {
        columnDescriptor.Item().PaddingVertical(FormattingSettings.BULLETPOINTSPACINGVERTICAL).PaddingLeft(indent * FormattingSettings.TAB)
            .Row(row =>
            {
                row.ConstantItem(FormattingSettings.FONTSIZE).Svg(bulletPointGraphicPath);
                row.RelativeItem().Text(" " + content);
            });
    }

    public static void BulletPoint(RowDescriptor rowDescriptor, string content, string bulletPointGraphicPath = FormattingSettings.DEFAULTBULLETPOINT)
    {
        rowDescriptor.RelativeItem()
            .Row(row =>
            {
                row.ConstantItem(FormattingSettings.FONTSIZE).Svg(bulletPointGraphicPath);
                row.AutoItem().Text(" " + content);
            });
    }
}
