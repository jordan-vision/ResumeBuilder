namespace ResumeBuilder;

class JobManager
{
    public static List<Job> WorkExperience = [];
    public static List<Job> Extracurricular = [];

    static bool jobsSetup = false;
    static bool extracurricularSetup = false;

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
        vrettaSoftware.Accomplishments.Add("vrettastudents");
        vrettaSoftware.Accomplishments.Add("vrettacss");
        vrettaSoftware.Accomplishments.Add("vrettasql");
        
        //Hogg
        hogg.Include = false;

        // Concordia
        concordia.Include = true;
        concordiaTutor.Accomplishments.Add("concordiastudents");

        // TransPerfect
        transperfect.Include = false;

        // Ubisoft
        ubisoft.Include = true;
        ubisoftIntern.Accomplishments.Add("ubisoftcicd");
        ubisoftIntern.Accomplishments.Add("ubisoftblazor");
        ubisoftIntern.Accomplishments.Add("ubisoftagile");

        // Genetec
        genetec.Include = true;
        genetecIntern.Accomplishments.Add("geneteccameraoop");
        genetecIntern.Accomplishments.Add("genetecbackend");
        genetecIntern.Accomplishments.Add("genetecdevops");
        // ---- EDIT END HERE ----

        jobsSetup = true;
    }

    public static void SetupExtraCurricular()
    {
        if (extracurricularSetup)
        {
            return;
        }

        // CGD
        Position cgdHead = new("techhead", (7, 25), (12, 25));
        Position cgdStaff = new("techstaff", (6, 24), (7, 25));
        Job cgd = new("cgd");
        cgd.Positions.Add(cgdHead);
        cgd.Positions.Add(cgdStaff);
        Extracurricular.Add(cgd);

        // Music Club
        Position musicClubCofounder = new("cofounderexecutive", (10, 22), (9, 25));
        Job musicClub = new("musicclub");
        musicClub.Positions.Add(musicClubCofounder);
        Extracurricular.Add(musicClub);

        // Game Lab
        Position gameLabProgrammer = new("uiprogrammer", (2, 24), (4, 24));
        Job gameLab = new("gamelab");
        gameLab.Positions.Add(gameLabProgrammer);
        Extracurricular.Add(gameLab);

        // Somm
        Position sommTeacher = new("pianoteacher", (2, 22), (4, 22));
        Job somm = new("somm");
        somm.Positions.Add(sommTeacher);
        Extracurricular.Add(somm);

        // VRConcert
        Position vrconcertprogrammer = new("designerprogrammer", (3, 24), (3, 24));
        Job vrconcert = new("vrconcert");
        vrconcert.Positions.Add(vrconcertprogrammer);
        Extracurricular.Add(vrconcert);

        // Game jams
        Position gamejamparticipant = new("participant", (7, 20), (10, 24));
        Job gamejams = new("gamejams");
        gamejams.Positions.Add(gamejamparticipant);
        Extracurricular.Add(gamejams);

        // ---- EDIT START HERE----
        // CGD
        cgd.Include = true;
        cgdHead.Accomplishments.Add("cgdwebsite");

        // Music Club
        musicClub.Include = false;
        musicClubCofounder.Accomplishments.Add("musicclubduties");

        // Game Lab
        gameLab.Include = true;
        gameLabProgrammer.Accomplishments.Add("gamelablan");

        // Somm
        somm.Include = false;

        // VRConcert
        vrconcert.Include = false;
        vrconcertprogrammer.Accomplishments.Add("vrconcertdescription");

        // Game jams
        gamejams.Include = false;
        gamejamparticipant.Accomplishments.Add("topspots");
        // ---- EDIT END HERE ----

        extracurricularSetup = true;
    }
}
