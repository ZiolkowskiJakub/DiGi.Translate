namespace DiGi.Translate.Classes
{
    /// <summary>
    /// Represents a language used for translation purposes.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Gets the name of the language.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class using the specified name.
        /// </summary>
        /// <param name="name">The name of the language.</param>
        public Language(string name)
        {
            Name = name == null ? string.Empty : name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class using another <see cref="Language"/> object.
        /// </summary>
        /// <param name="language">The source language object to copy from.</param>
        public Language(Language language)
        {
            Name = language?.Name == null ? string.Empty : language.Name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class using the specified language enumeration value.
        /// </summary>
        /// <param name="language">The language enumeration value used to initialize the current instance.</param>
        public Language(Enums.Language language)
        {
            Name = language.ToString();
        }

        /// <summary>
        /// Returns a string that represents the current language's name.
        /// </summary>
        /// <returns>The language name.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Language"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns><see langword="true"/> if the objects are considered equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        /// <summary>
        /// Returns a hash code for the current <see cref="Language"/> instance.
        /// </summary>
        /// <returns>The hash code of the language.</returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        /// <summary>
        /// Implicitly converts a string representation of a language name to a <see cref="Language"/> object.
        /// </summary>
        /// <param name="name">The name of the language to convert.</param>
        /// <returns>A new <see cref="Language"/> instance created from the specified name.</returns>
        public static implicit operator Language(string name)
        {
            return new Language(name);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Enums.Language"/> enumeration value to a <see cref="Language"/> object.
        /// </summary>
        /// <param name="language">The language enumeration value to convert.</param>
        /// <returns>A new <see cref="Language"/> instance created from the specified enumeration value.</returns>
        public static implicit operator Language(Enums.Language language)
        {
            return new Language(language);
        }

        /// <summary>
        /// Indicates whether the specified <see cref="Language"/> objects are equal.
        /// </summary>
        /// <param name="language_1">The first <see cref="Language"/> object to compare.</param>
        /// <param name="language_2">The second <see cref="Language"/> object to compare.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Indicates whether the specified <see cref="Language"/> objects are not equal.
        /// </summary>
        /// <param name="language_1">The first <see cref="Language"/> object to compare.</param>
        /// <param name="language_2">The second <see cref="Language"/> object to compare.</param>
        /// <returns><see langword="true"/> if the objects are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Language language_1, Language language_2)
        {
            return language_1?.Name != language_2?.Name;
        }
    }
}