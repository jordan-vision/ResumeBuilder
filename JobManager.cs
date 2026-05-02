namespace ResumeBuilder;

class JobManager
{
    public static List<Job> WorkExperience = [];
    public static List<Job> Volunteering = [];

    public static void SetupJobs()
    {
        Position vrettaSoftware = new();
        vrettaSoftware.Title = "softwaredev";
        vrettaSoftware.StartMonth = (1, 26);
        vrettaSoftware.EndMonth = (4, 26);

        Job vretta = new();
        vretta.Company = "Vretta";
        vretta.Positions.Add(vrettaSoftware);
        WorkExperience.Add(vretta);

        // ---- EDIT START HERE ----
        vretta.Include = true;
        vretta.ShowDetails = true;
        vrettaSoftware.Accomplishments.Add("vrettaStudents");
        vrettaSoftware.Accomplishments.Add("vrettasql");
        vrettaSoftware.Accomplishments.Add("vrettagov");
        // ---- EDIT END HERE ----
    }
}
