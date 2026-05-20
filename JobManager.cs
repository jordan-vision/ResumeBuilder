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
        vrettaSoftware.Accomplishments.Add("vrettadoc");

        //Hogg
        hogg.Include = false;
        hogg.ShowDetails = false;

        // Concordia
        concordia.Include = true;
        concordia.ShowDetails = false;

        // TransPerfect
        transperfect.Include = false;
        transperfect.ShowDetails = false;

        // Ubisoft
        ubisoft.Include = true;
        ubisoft.ShowDetails = true;
        ubisoftIntern.Accomplishments.Add("ubisoftwpf");
        ubisoftIntern.Accomplishments.Add("ubisoftshell");
        ubisoftIntern.Accomplishments.Add("ubisoftagile");

        // Genetec
        genetec.Include = true;
        genetec.ShowDetails = true;
        genetecIntern.Accomplishments.Add("geneteccamera");
        genetecIntern.Accomplishments.Add("genetecbackend");
        genetecIntern.Accomplishments.Add("genetecport");
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

        // Music Club
        Position musicClubCofounder = new("cofounderexecutive", (10, 22), (9, 25));
        Job musicClub = new("musicclub");
        musicClub.Positions.Add(musicClubCofounder);
        Volunteering.Add(musicClub);

        // Game Lab
        Position gameLabProgrammer = new("uiprogrammer", (2, 24), (4, 24));
        Job gameLab = new("gamelab");
        gameLab.Positions.Add(gameLabProgrammer);
        Volunteering.Add(gameLab);

        // Somm
        Position sommTeacher = new("pianoteacher", (2, 22), (4, 22));
        Job somm = new("somm");
        somm.Positions.Add(sommTeacher);
        Volunteering.Add(somm);

        // VRConcert
        Position vrconcertprogrammer = new("designerprogrammer", (3, 24), (3, 24));
        Job vrconcert = new("vrconcert");
        vrconcert.Positions.Add(vrconcertprogrammer);
        Volunteering.Add(vrconcert);

        // ---- EDIT START HERE ----
        // CGD
        cgd.Include = false;
        cgd.ShowDetails = false;
        cgdHead.Accomplishments.Add("cgdwebsite");

        // Music Club
        musicClub.Include = false;
        musicClub.ShowDetails = false;

        // Game Lab
        gameLab.Include = true;
        gameLab.ShowDetails = true;
        gameLabProgrammer.Accomplishments.Add("gamelablan");

        // Somm
        somm.Include = false;
        somm.ShowDetails = false;

        // VRConcert
        vrconcert.Include = true;
        vrconcert.ShowDetails = true;
        vrconcertprogrammer.Accomplishments.Add("vrconcertdescription");
        // ---- EDIT END HERE ----

        volunteeringSetup = true;
    }
}
