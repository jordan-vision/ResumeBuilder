namespace ResumeBuilder;

class Translations
{
    public const string ENGLISH = "en";
    public const string FRENCH = "fr";

    private static Dictionary<string, Dictionary<string, string>> translations = new();

    public static string CurrentLanguage = ENGLISH;

    public static void SetupTranslations()
    {
        translations.Add(ENGLISH, new()
        {
            { "contactTitle", "CONTACT" },
            { "educationTitle", "EDUCATION" },
            { "skillsTitle", "SKILLS" },
            { "languagesTitle", "LANGUAGES" },

        });

        translations.Add(FRENCH, new()
        {
            { "contactTitle", "CONTACT" },
            { "educationTitle", "ÉDUCATION" },
            { "skillsTitle", "COMPÉTENCES" },
            { "languagesTitle", "LANGUES" },

        });
    }

    public static string Get(string slug)
    {
        return translations[CurrentLanguage][slug];
    }
}
