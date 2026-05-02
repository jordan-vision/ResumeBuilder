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
            { "workExperienceTitle", "WORK EXPERIENCE" },
            { "volunteeringTitle", "VOLUNTEERING" },

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

            // Vretta
            { "softwaredev", "Software Developer" },
            { "vrettaStudents", "Developed online test designs platforms used by over 800,000 K-12 students in 4 provinces" },
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
            { "workExperienceTitle", "EXPÉRIENCE PROFESSIONELLE" },
            { "volunteeringTitle", "VOLONTARIAT" },

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

            // Vretta
            { "softwaredev", "Développeur de Logiciels" },
            { "vrettaStudents", "Développer des plateformes de conception d'évaluations scolaires utilisées par plus de 800,000 étudiants dans 4 provinces" },
        });
    }

    public static string Get(string slug)
    {
        return translations[ResumeSettings.CURRENTLANGUAGE][slug];
    }

    public static string Dates((int, int) start, (int, int) end)
    {
        var (startMonth, startYear) = start;
        var (endMonth, endYear) = end;

        var startMonthString = MonthNumberToName(startMonth);
        var endMonthString = MonthNumberToName(endMonth);

        return startMonthString + " 20" + startYear + " - " + endMonthString + " 20" + endYear;
    }

    static string MonthNumberToName(int monthNumber)
    {
        var returnValue = "";

        switch(monthNumber)
        {
            case 1:
                returnValue = "JAN";
                break;

            case 2:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "FEB";
                } else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "FÉV";
                }
                break;

            case 3:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "MAR";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "MARS";
                }
                break;

            case 4:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "APR";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "AVR";
                }
                break;

            case 5:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "MAY";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "MAI";
                }
                break;

            case 6:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "JUNE";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "JUIN";
                }
                break;

            case 7:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "JULY";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "JUIL";
                }
                break;

            case 8:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "AUG";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "AOÛT";
                }
                break;

            case 9:
                returnValue = "SEP";
                break;

            case 10:
                returnValue = "OCT";
                break;

            case 11:
                returnValue = "NOV";
                break;

            case 12:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "DEC";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "DÉC";
                }
                break;
        }

        return returnValue;
    }
}
