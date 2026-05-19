namespace ResumeBuilder;

internal class Skills
{
    // Hard skills
    const string FULLSTACK = "fullstack";
    const string DEVOPS = "devops";
    const string DATABASES = "databases";
    const string OOP = "oop";
    const string MULTITHREAD = "multithread";

    // Languages
    const string CSHARP = "C#";
    const string CPP = "C/C++";
    const string JAVA = "Java";
    const string PYTHON = "Python";
    const string JS = "JavaScript";
    const string HTML = "HTML";
    const string SQL = "SQL";
    const string TS = "TypeScript";

    // Frameworks
    const string ANGULAR = "Angular";
    const string ASP = "ASP.NET";
    const string BLAZOR = "Blazor";
    const string OPENGL = "OpenGL";
    const string DOTNET = ".NET";
    const string REACT = "React";
    const string NODE = "NodeJS";

    // IDEs
    const string VS = "Visual Studio";
    const string VSCODE = "Visual Studio Code";
    const string ECLIPSE = "ECLIPSE";
    const string IDLE = "IDLE";

    // Game Engines
    const string UNITY = "Unity Engine";
    const string UNREAL = "Unreal Engine";

    // OS
    const string LINUX = "Linux";
    const string WINDOWS = "Windows";
    const string WSL = "Ubuntu";

    // Other Software
    const string NOTION = "Notion";
    const string MSOFFICE = "Microsoft Office Suite";
    const string GITLAB = "GitLab";

    // Soft skills
    const string PROBLEM = "problem";
    const string TEAMWORK = "teamwork";
    const string MENTOR = "mentorship";


    // ---- EDIT START HERE ----
    public static readonly string[] RELEVANTHARDSKILLS =
    {
        OOP,
        MULTITHREAD,
    };
    public static readonly string[] RELEVANTLANGUAGES =
    {
        CSHARP,
        JAVA,
        CPP,
        JS,
        TS,
    };
    public static readonly string[] RELEVANTFRAMEWORKS =
    {
        DOTNET,
        ANGULAR,
        NODE,
    };
    public static readonly string[] RELEVANTIDES =
    {
        VS,
    };
    public static readonly string[] RELEVANTGAMEENGINES =
    {
        
    };
    public static readonly string[] RELEVANTOS =
    {
        LINUX,
        WINDOWS,
        WSL,
    };
    public static readonly string[] RELEVANTSOFTWARE =
    {
        GITLAB
    };
    public static readonly string[] RELEVANTSOFTSKILLS =
    {
        TEAMWORK,
        PROBLEM
    };
    // ---- EDIT END HERE ----
}
