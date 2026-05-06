
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

    public enum SortingMethod
    {
        Start,
        End
    }


    // ---- EDIT START HERE ----
    public const string CURRENTLANGUAGE = Translations.FRENCH;
    const JobPositions JOBPOSITION = JobPositions.Dev;
    public const SortingMethod SORTINGMETHOD = SortingMethod.End;
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
