namespace ResumeBuilder;

class FormattingSettings
{
    public const int BODYPADDING = 18; // Space between title and body in points
    public const int BULLETPOINTSPACING = 1; // Space above and below each item in a bulleted list.
    public const string DEFAULTBULLETPOINT = "Resources/bullet-point.svg"; // Path of default graphic for bullet point
    public const string FONTCOLOR = "575757"; // Hex code of text color unless otherwise specified
    public const int FONTSIZE = 11; // Size of all text unless otherwise specified, in points
    public const int LINEWIDTH = 1; // Width of borders in points
    public const int MIDDLEPADDING = 4; // Space on left or right of a section in points
    public const int NAMEFONTSIZE = 28; // Size of name in points
    public const int PAGEMARGIN = 36; // Margin in points
    public const int SECTIONPADDING = 12; // Space between sections in points
    public const int SECTIONTITLEFONTSIZE = 14; // Sized of the name of a section in points
    public const int SECTIONTITLEPADDING = 8; // Space below the name of a section in points
    public const float SIDEBARFACTOR = 1.0f / 3.0f; // Portion of the page that is the left column, between 0 and 1
    public const int TITLEFONTSIZE = 12; // Size of job title in points
    public const int TITLEPADDING = 12; // Space above and below name and job title block in points
}
