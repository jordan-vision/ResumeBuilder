namespace ResumeBuilder;

class JobManager
{
    public static List<Job> WorkExperience = [];
    public static List<Job> Volunteering = [];

    static bool jobsSetup = false;
    static bool volunteeringSetup = false;

    public static void SetupJobs()
    {
        if (jobsSetup)
        {
            return;
        }

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

        // Concordia
        Position concordiaTutor = new("mathtutor", (1, 23), (12, 25));
        Job concordia = new("concordiawork");
        concordia.Positions.Add(concordiaTutor);
        WorkExperience.Add(concordia);

        // TransPerfect
        Position transperfectannotator = new("dataannotator", (6, 25), (7, 25));
        Job transperfect = new("transperfect");
        transperfect.Positions.Add(transperfectannotator);
        WorkExperience.Add(transperfect);

        // Ubisoft
        Position ubisoftIntern = new("toolsprogrammerintern", (5, 24), (8, 24));
        Job ubisoft = new("ubisoft");
        ubisoft.Positions.Add(ubisoftIntern);
        WorkExperience.Add(ubisoft);

        // Genetec
        Position genetecIntern = new("softwaredevintern", (9, 23), (12, 23));
        Job genetec = new("genetec");
        genetec.Positions.Add(genetecIntern);
        WorkExperience.Add(genetec);

        // ---- EDIT START HERE ----
        // Vretta
        vretta.Include = true;
        vretta.ShowDetails = true;
        vrettaSoftware.Accomplishments.Add("vrettaStudents");
        vrettaSoftware.Accomplishments.Add("vrettasql");
        vrettaSoftware.Accomplishments.Add("vrettagov");

        //Hogg
        hogg.Include = true;
        hogg.ShowDetails = true;

        // Concordia
        concordia.Include = true;
        concordia.ShowDetails = true;

        // TransPerfect
        transperfect.Include = true;
        transperfect.ShowDetails = true;

        // Ubisoft
        ubisoft.Include = true;
        ubisoft.ShowDetails = true;

        // Genetec
        genetec.Include = true;
        genetec.ShowDetails = true;
        // ---- EDIT END HERE ----

        jobsSetup = true;
    }

    public static void SetupVolunteering()
    {
        if (volunteeringSetup)
        {
            return;
        }

        // CGD
        Position cgdHead = new("techhead", (7, 25), (12, 25));
        Position cgdStaff = new("techstaff", (6, 24), (7, 25));
        Job cgd = new("cgd");
        cgd.Positions.Add(cgdHead);
        cgd.Positions.Add(cgdStaff);
        Volunteering.Add(cgd);

        // ---- EDIT START HERE ----
        // CGD
        cgd.Include = true;
        cgd.ShowDetails = true;
        // ---- EDIT END HERE ----

        volunteeringSetup = true;
    }
}
