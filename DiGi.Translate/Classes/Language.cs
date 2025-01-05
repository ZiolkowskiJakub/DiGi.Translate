
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
    }
}
