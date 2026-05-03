namespace ResumeBuilder;

class JobManager
{
    public static List<Job> WorkExperience = [];
    public static List<Job> Volunteering = [];

    public static void SetupJobs()
    {
        // Vretta
        Position vrettaSoftware = new("softwaredev", (1, 26), (4, 26));
        Job vretta = new("vretta");
        vretta.Positions.Add(vrettaSoftware);
        WorkExperience.Add(vretta);

        // Hogg
        Position hoggClerk = new("clerk", (7, 25), (12, 25));
        Job hogg = new("hogg");
        hogg.Positions.Add(hoggClerk);
        WorkExperience.Add(hogg);

        // ---- EDIT START HERE ----
        // Vretta
        vretta.Include = true;
        vretta.ShowDetails = false;
        vrettaSoftware.Accomplishments.Add("vrettaStudents");
        vrettaSoftware.Accomplishments.Add("vrettasql");
        vrettaSoftware.Accomplishments.Add("vrettagov");

        //Hogg
        hogg.Include = true;
        hogg.ShowDetails = true;
        // ---- EDIT END HERE ----
    }
}
