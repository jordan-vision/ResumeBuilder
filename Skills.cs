namespace ResumeBuilder;

internal class Skills
{
    // Hard skills
    const string FULLSTACK = "fullstack";
    public static readonly string[] RELEVANTHARDSKILLS = 
    { 
        FULLSTACK,
    };

    // Languages
    const string CSHARP = "C#";
    const string CPLUSPLUS = "C/C++";
    const string JAVA = "Java";
    const string PYTHON = "Python";
    const string JAVASCRIPT = "JavaScript";
    const string HTML = "HTML";
    const string SQL = "SQL";
    public static readonly string[] RELEVANTLANGUAGES =
    {
        CSHARP,
        CPLUSPLUS,
        JAVA,
        PYTHON,
    };

    // Frameworks
    const string ANGULAR = "Angular";
    const string ASP = "ASP.NET";
    const string BLAZOR = "Blazor";
    const string OPENGL = "OpenGL";
    public static readonly string[] RELEVANTFRAMEWORKS =
    {
        ANGULAR,
        ASP,
        BLAZOR,
    };

    // IDEs
    const string VS = "Visual Studio";
    const string VSCODE = "Visual Studio Code";
    const string ECLIPSE = "ECLIPSE";
    const string IDLE = "IDLE";
    public static readonly string[] RELEVANTIDES =
    {
        VS,
        ECLIPSE,
    };

    // Game Engines
    const string UNITY = "Unity Engine";
    const string UNREAL = "Unreal Engine";
    public static readonly string[] RELEVANTGAMEENGINES =
    {
        UNITY,
        UNREAL,
    };

    // OS
    const string LINUX = "Linux";
    const string WINDOWS = "Windows";
    const string WSL = "Ubuntu";
    public static readonly string[] RELEVANTOS =
    {
        LINUX,
        WSL,
    };

    // Other Software
    const string NOTION = "Notion";
    const string MSOFFICE = "Microsoft Office Suite";
    public static readonly string[] RELEVANTSOFTWARE =
    {
        NOTION,
        MSOFFICE,
    };

    // Soft skills
    const string PROBLEM = "problem";
    public static readonly string[] RELEVANTSOFTSKILLS =
    {

    };
}
