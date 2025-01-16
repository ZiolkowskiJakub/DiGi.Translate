
namespace DiGi.Translate.Classes
{
    public class Language
    {
        public string Name { get; }

        public Language(string name)
        {
            Name = name == null ? string.Empty : name;
        }

        public Language(Language language)
        {
            Name = language?.Name == null ? string.Empty : language.Name;
        }

        public Language(Enums.Language language)
        {
            Name = language.ToString();
        }

        public override string ToString() 
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public static implicit operator Language(string name)
        {
            return new Language(name);
        }

        public static implicit operator Language(Enums.Language language)
        {
            return new Language(language);
        }
        
        public static bool operator ==(Language language_1, Language language_2)
        {
            if (Equals(language_1, language_2))
            {
                return true;
            }

            if (Equals(language_1, null))
            {
                return false;
            }

            if (Equals(language_2, null))
            {
                return false;
            }

            return language_1.Name == language_2.Name;
        }
        
        public static bool operator !=(Language language_1, Language language_2)
        {
            return language_1?.Name != language_2?.Name;
        }
    }
}
