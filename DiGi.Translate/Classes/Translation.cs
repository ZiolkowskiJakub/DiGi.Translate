using System.Collections.Generic;

namespace DiGi.Translate.Classes
{
    /// <summary>
    /// Represents a translation entry that associates a unique identifier and category with localized strings for various languages.
    /// </summary>
    public class Translation
    {
        private readonly Category? category;
        private readonly string? id;
        private readonly Dictionary<Language, string> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the Translation class with the specified category and identifier.
        /// </summary>
        /// <param name="category">The category associated with the translation.</param>
        /// <param name="id">The unique identifier for the translation.</param>
        public Translation(Category? category, string? id)
        {
            this.category = category is null ? null : new Category(category);
            this.id = id;
        }

        /// <summary>
        /// Adds or updates a translation for the specified language.
        /// </summary>
        /// <param name="language">The language to associate with the translated text.</param>
        /// <param name="text">The translated text to be added.</param>
        /// <returns><c>true</c> if the translation was successfully added; otherwise, <c>false</c>.</returns>
        public bool Add(Language language, string text)
        {
            if (language is null)
            {
                return false;
            }

            dictionary[language] = text;
            return true;
        }

        /// <summary>
        /// Attempts to retrieve the translated text for the specified language.
        /// </summary>
        /// <param name="language">The language used to look up the translation.</param>
        /// <param name="text">When this method returns, contains the translated text if the operation succeeded; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if the translation was successfully retrieved and is not null or empty; otherwise, <c>false</c>.</returns>
        public bool TryGetText(Language? language, out string? text)
        {
            if (language is null || !dictionary.TryGetValue(language, out text) || string.IsNullOrEmpty(text))
            {
                text = null;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the translated text for the specified language.
        /// </summary>
        /// <param name="language">The language for which to retrieve the translation.</param>
        /// <returns>The translated string if found; otherwise, <c>null</c>.</returns>
        public string? this[Language? language]
        {
            get
            {
                if (!TryGetText(language, out string? result))
                {
                    result = null;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets the category associated with the translation.
        /// </summary>
        public Category? Category
        {
            get
            {
                return category;
            }
        }

        /// <summary>
        /// Gets the unique identifier of the translation.
        /// </summary>
        public string? Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Gets the collection of all languages currently stored.
        /// </summary>
        public HashSet<Language>? Languages
        {
            get
            {
                return [.. dictionary.Keys];
            }
        }
    }
}