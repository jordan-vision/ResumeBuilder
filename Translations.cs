namespace ResumeBuilder;

class Translations
{
    public const string ENGLISH = "en";
    public const string FRENCH = "fr";

    private static Dictionary<string, Dictionary<string, string>> translations = new();

    public static void SetupTranslations()
    {
        translations.Add(ENGLISH, new()
        {
            // Position titles
            { "dev", "SOFTWARE DEVELOPER" },
            { "game", "GAME DEVELOPER" },
            { "tutor", "MATH TUTOR" },

            // Section titles
            { "contactTitle", "CONTACT" },
            { "educationTitle", "EDUCATION" },
            { "skillsTitle", "SKILLS" },
            { "languagesTitle", "LANGUAGES" },

            // Education
            { "concordia", "CONCORDIA UNIVERSITY" },
            { "compsci", "Bachelor of Computer Science" },
            { "deansList", "Dean’s List 2022-2023 & 2023-2024" },

            // Skills
            { "fullstack", "Fullstack Development" },
            { "problem", "Problem Solving" },

            // Languages
            { "english", "English: Fluent" },
            { "french", "French: Fluent" },
            { "spanish", "Spanish: Beginner" },
        });

        translations.Add(FRENCH, new()
        {
            // Position titles
            { "dev", "DÉVELOPPEUR DE LOGICIELS" },
            { "game", "DÉVELOPPEUR DE JEUX" },
            { "tutor", "TUTEUR DE MATHÉMATIQUES" },

            // Section titles
            { "contactTitle", "CONTACT" },
            { "educationTitle", "ÉDUCATION" },
            { "skillsTitle", "COMPÉTENCES" },
            { "languagesTitle", "LANGUES" },

            // Educaation
            { "concordia", "UNIVERSITÉ CONCORDIA" },
            { "compsci", "Bachelor en Informatique" },
            { "deansList", "Liste du Doyen 2022-2023 et 2023-2024" },

            // Skills
            { "fullstack", "Développement Fullstack" },
            { "problem", "Résolution de problèmes" },

            // Languages
            { "english", "Anglais: Courant" },
            { "french", "Français: Courant" },
            { "spanish", "Espagnol: Débutant" },
        });
    }

    public static string Get(string slug)
    {
        return translations[ResumeSettings.CURRENTLANGUAGE][slug];
    }
}
