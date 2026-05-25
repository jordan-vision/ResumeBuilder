namespace ResumeBuilder;

internal class Skills
{
    // Hard skills
    const string FULLSTACK = "fullstack";
    const string DEVOPS = "devops";
    const string DATABASES = "databases";
    const string OOP = "oop";
    const string MULTITHREAD = "multithread";
    const string BACKEND = "backend";
    const string NETWORK = "network";
    const string RELATIONAL = "relational";
    const string CALCULUS = "calculus";
    const string LINEAR = "linear";
    const string GAMEDEV = "gamedev";
    const string CICD = "cicd";
    const string WEB = "web";
    const string MVC = "mvc";
    const string TOOLS = "tools";
    const string FRONTEND = "frontend";
    const string UI = "ui";

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
    const string NODE = "Node.js";
    const string WPF = "WPF";

    // IDEs
    const string VS = "Visual Studio";
    const string VSCODE = "Visual Studio Code";
    const string ECLIPSE = "Eclipse";
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
    const string GIT = "Git";
    const string GITLAB = "GitLab";
    const string GITHUB = "GitHub";
    const string AWS = "AWS";
    const string AZURE = "Azure";
    const string BLENDER = "Blender";
    const string DOCKER = "Docker";
    const string K8S = "Kubernetes";

    // Soft skills
    const string PROBLEM = "problem";
    const string TEAMWORK = "teamwork";
    const string MENTOR = "mentorship";
    const string ADAPT = "adaptability";


    // ---- EDIT START HERE ----
    public static readonly string[] RELEVANTHARDSKILLS =
    {
        FULLSTACK,
        TOOLS,
        DATABASES,
        GAMEDEV,
        CICD,
    };
    public static readonly string[] RELEVANTLANGUAGES =
    {
        CSHARP,
        JAVA,
        TS,
        SQL,
    };
    public static readonly string[] RELEVANTFRAMEWORKS =
    {
        REACT
    };
    public static readonly string[] RELEVANTIDES =
    {
        VS,
        VSCODE,
    };
    public static readonly string[] RELEVANTGAMEENGINES =
    {
        UNITY,
        UNREAL,
    };
    public static readonly string[] RELEVANTOS =
    {

    };
    public static readonly string[] RELEVANTSOFTWARE =
    {
        GIT,
        DOCKER,
        K8S,
    };
    public static readonly string[] RELEVANTSOFTSKILLS =
    {
        TEAMWORK,
        ADAPT,
    };
    // ---- EDIT END HERE ----
}
