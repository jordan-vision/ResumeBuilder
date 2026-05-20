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
            { "volunteeringTitle", "VOLUNTEERING & PERSONAL PROJECTS" },

            // Education
            { "concordia", "CONCORDIA UNIVERSITY" },
            { "compsci", "Bachelor of Computer Science" },
            { "deansList", "Dean’s List 2022-2023 & 2023-2024" },

            // Skills
            { "fullstack", "Fullstack Development" },
            { "devops", "DevOps" },
            { "databases", "Databases" },
            { "oop", "Object Oriented Programming" },
            { "multithread", "Multithread Programming" },
            { "backend", "Back-end Development" },
            { "network", "Network Programming" },
            { "relational", "Relational Databases" },
            { "problem", "Problem Solving" },
            { "teamwork", "Teamwork & Communication" },
            { "mentorship", "Mentorship" },

            // Languages
            { "english", "English: Fluent" },
            { "french", "French: Fluent" },
            { "spanish", "Spanish: Beginner" },

            // Vretta
            { "vretta", "Vretta" },
            { "softwaredev", "Software Developer" },
            { "vrettaStudents", "Developed an online platform with Angular, with the purpose of designing assessments for over 800,000 students in 4 provinces" },
            { "vrettasql", "Scripted SQL queries and API endpoints in TypeScript to optimize the transfer of hundreds of gigabytes of data between the database, the back-end, and the front-end" },
            { "vrettasqlbackend", "Scripted SQL queries and back-end API endpoints in TypeScript to optimize the transfer of hundreds of gigabytes of data between the database, the back-end, and the front-end" },
            { "vrettagov", "Worked closely with provincial agencies to fine-tune features to each agency's preference, ensuring customer satisfaction" },
            { "vrettadoc", "Documented quality assurance plans and user flows for each change in the code, enabling users and quality assurance staff to keep track of them" },

            // Hogg
            { "hogg", "Hogg Hardware" },
            { "clerk", "Clerk" },

            // Concordia
            { "concordiawork", "Concordia University" },
            { "mathtutor", "Math Tutor" },

            // TransPerfect
            { "transperfect", "TransPerfect" },
            { "dataannotator", "Language Data Annotator" },

            // Ubisoft
            { "ubisoft", "Ubisoft" },
            { "toolsprogrammerintern", "Tools Programmer Intern" },
            { "ubisoftcicd", "Developed an ASP.NET web app in C# that distributes CI/CD pipelines across the local network, greatly reducing cloud server expenses" },
            { "ubisoftagile", "Worked within an Agile team, actively contributed in discussing improvements in performance and usability, and used GitLab for version control" },
            { "ubisoftblazor", "Constructed the app's UI from the ground up in HTML and CSS, through the Blazor framework" },

            // Genetec
            { "genetec", "Genetec" },
            { "softwaredevintern", "Software Developer Intern" },
            { "geneteccamera", "Developed the infrastructure for two security camera models in .NET C#, one built upon Windows and the other upon Linux" },
            { "geneteccameraoop", "Developed an object-oriented infrastructure for two security camera models in .NET C#, one built upon Windows and the other upon Linux" },
            { "genetecport", "Ported the web portal for managing these cameras, coded in JavaScript, from React to Angular" },
            { "genetecbilingual", "Operated within a highly French/English bilingual team and company, with a focus on Agile and Kanban methods" },
            { "genetecmultithread", "Programming asynchronous solutions to complex multithreading problems" },
            { "genetecbackend", "Used .NET's built-in HTTP network features to program fast and foolproof back-end methods that reliably support multithreading" },

            // CGD
            { "cgd", "Concordia Game Development" },
            { "techhead", "Head of Technology" },
            { "cgdwebsite", "Managed and contributed to the development of the official Concordia Game Development website, using React and TypeScript" },
            { "techstaff", "Tech Staff" },
            { "cgddiscord", "Developed a Discord bot for staff productivity in Python" },

            // Music club
            { "musicclub", "Concordia Music Club" },
            { "cofounderexecutive", "Co-founder & Executive" },

            // Game Lab
            { "gamelab", "Ubisoft Game Lab" },
            { "uiprogrammer", "UI Programmer" },
            { "gamelablan", "Programmed the user interface for a LAN multiplayer computer game in the Unity Engine" },

            // Somm
            { "somm", "School of Music Montreal" },
            { "pianoteacher", "Piano Teacher" },
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
            { "volunteeringTitle", "VOLONTARIAT ET PROJETS PERSONNELS" },

            // Educaation
            { "concordia", "UNIVERSITÉ CONCORDIA" },
            { "compsci", "Bachelor en Informatique" },
            { "deansList", "Liste du Doyen 2022-2023 et 2023-2024" },

            // Skills
            { "fullstack", "Développement Fullstack" },
            { "devops", "DevOps" },
            { "databases", "Bases de Données" },
            { "oop", "Programmation Orientée Objet" },
            { "multithread", "Programmation Multithread" },
            { "backend", "Développement Back-end" },
            { "network", "Programmation Réseau" },
            { "relational", "Bases de Données Relationnelles" },
            { "problem", "Résolution de problèmes" },
            { "teamwork", "Communication et Travail d'Équipe" },
            { "mentorship", "Mentorat" },

            // Languages
            { "english", "Anglais: Courant" },
            { "french", "Français: Courant" },
            { "spanish", "Espagnol: Débutant" },

            // Vretta
            { "vretta", "Vretta" },
            { "softwaredev", "Développeur de Logiciels" },
            { "vrettaStudents", "Développer une plateforme de conception d'évaluations avec Angular, pour plus de 800,000 élèves dans 4 provinces" },
            { "vrettasql", "Scripter des requêtes SQL et des endpoints API en TypeScript pour optimiser le transfert de centaines de giga-octets de données entre la base de données, le back-end, et le front-end" },
            { "vrettasqlbackend", "Scripter des requêtes SQL et des endpoints API dans le back-end en TypeScript pour optimiser le transfert de centaines de giga-octets de données entre la base de données, le back-end, et le front-end" },
            { "vrettagov", "Travailler avec les agences provinciales pout affiner les fonctionnalités selon leurs préférences, assurant ainsi la satisfaction des clients" },
            { "vrettadoc", "Documenterles plans d'assurance qualité et les user flow pour chaque modification du code, pour que les utilisateurs et le personnel d'assurance qualité puisse en garder une trace" },

            // Hogg
            { "hogg", "Quincaillerie Hogg" },
            { "clerk", "Commis" },

            // Concordia
            { "concordiawork", "Université Concordia" },
            { "mathtutor", "Tuteur de Mathénatiques" },

            // TransPerfect
            { "transperfect", "TransPerfect" },
            { "dataannotator", "Annotateur de Données Linguistiques" },

            // Ubisoft
            { "ubisoft", "Ubisoft" },
            { "toolsprogrammerintern", "Stagiare en Programmation d'Outils" },
            { "ubisoftcicd", "Développer une application web ASP.NET en C# pour la distribution des pipelines CI/CD à travers le réseau local, diminuant ainsi les dépenses liées aux serveurs cloud" },
            { "ubisoftagile", "Travailler dans une équipe Agille, discuter des potentielles améliorations de performance et d'ergonomie, et utiliser GitLab pour le contrôle de versions" },
            { "ubisoftblazor", "Construire l'interface utilisateur à partir de zéro en HTML et CSS, à travers le framework Blazor" },

            // Genetec
            { "genetec", "Genetec" },
            { "softwaredevintern", "Stagiaire en Développement de Logiciels" },
            { "geneteccamera", "Développer une infrastructure pour deux modèles de caméras de sécurité en .NET C#, l'un basé sur Windows, et l'autre sur Linux" },
            { "geneteccameraoop", "Développer une infrastructure orientée objet pour deux modèles de caméras de sécurité en .NET C#, l'un basé sur Windows, et l'autre sur Linux" },
            { "genetecport", "Adapter le portail web pour la gestion de ces caméras, programmé avec JavaScript, de React à Angular" },
            { "genetecbilingual", "Opérer au sein d'une équipe et d'une companue hautement bilingue français/anglais, avec un focus sur les méthodes Agile et Kanban" },
            { "genetecmultithread", "Programmer des solutions asynchrones à des problèmes de multithreading complexes" },
            { "genetecbackend", "Utiliser les fonctionnalités réseau HTTP de .NET pour programmer des méthodes back-end rapides, infaillibles, et qui supportent le multithreading" },

            // CGD
            { "cgd", "Concordia Game Development" },
            { "techhead", "Directeur Technique" },
            { "cgdwebsite", "Gérer et contribuer au the développement du site officiel de Concordia Game Development, avec React and TypeScript" },
            { "techstaff", "Personnel Technique" },
            { "cgddiscord", "Développer un bot Discord pour la productivité du personnel en Python" },

            // Music club
            { "musicclub", "Club de Musique de Concordia" },
            { "cofounderexecutive", "Co-fondateur et Membre du Corps Exécutif" },

            // Game Lab
            { "gamelab", "Concours Universitaire Ubisoft" },
            { "uiprogrammer", "Programmeur d'Interface Utilisateur" },
            { "gamelablan", "Programmer l'interface utilisateur pour un jeu multijoueur LAN dans Unity Engine" },

            // Somm
            { "somm", "School of Music Montreal" },
            { "pianoteacher", "Professeur de Piano" },
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
                    returnValue = "JUN";
                }
                else if (ResumeSettings.CURRENTLANGUAGE == FRENCH)
                {
                    returnValue = "JUIN";
                }
                break;

            case 7:
                if (ResumeSettings.CURRENTLANGUAGE == ENGLISH)
                {
                    returnValue = "JUL";
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
