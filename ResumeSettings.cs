
namespace ResumeBuilder;

internal class ResumeSettings
{
    enum JobPositions
    {
        Dev,
        Game,
        Tutor,
        None
    }


    // ---- EDIT START HERE ----
    public const string CURRENTLANGUAGE = Translations.ENGLISH;
    const JobPositions JOBPOSITION = JobPositions.Dev;
    // ---- EDIT END HERE ----

    public static bool TryGetPosition(out string text)
    {
        var returnValue = true;

        // Get position title based on language and setting
        switch (JOBPOSITION)
        {
            case JobPositions.Dev:
                text = Translations.Get("dev");
                break;

            case JobPositions.Game:
                text = Translations.Get("game");
                break;

            case JobPositions.Tutor:
                text = Translations.Get("tutor");
                break;

            case JobPositions.None:
            default:
                returnValue = false;
                text = "";
                break;
        }

        return returnValue;
    }
}
