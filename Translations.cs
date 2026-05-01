namespace ResumeBuilder;

class Translations
{
    public const string ENGLISH = "en";
    public const string FRENCH = "fr";

    private static Dictionary<string, Dictionary<string, string>> translations = new();

    public static string CurrentLanguage = FRENCH;

    public static void SetupTranslations()
    {
        translations.Add(ENGLISH, new()
        {
            { "contactTitle", "CONTACT" },
            { "educationTitle", "EDUCATION" },
            { "skillsTitle", "SKILLS" },
            { "languagesTitle", "LANGUAGES" },
            { "concordia", "CONCORDIA UNIVERSITY" },
            { "compsci", "Bachelor of Computer Science" },
        });

        translations.Add(FRENCH, new()
        {
            { "contactTitle", "CONTACT" },
            { "educationTitle", "ÉDUCATION" },
            { "skillsTitle", "COMPÉTENCES" },
            { "languagesTitle", "LANGUES" },
            { "concordia", "UNIVERSITÉ CONCORDIA" },
            { "compsci", "Bachelor en Informatique" },
        });
    }

    public static string Get(string slug)
    {
        return translations[CurrentLanguage][slug];
    }
}
