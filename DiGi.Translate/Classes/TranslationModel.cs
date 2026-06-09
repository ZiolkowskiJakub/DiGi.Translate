using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Translate.Classes
{
    /// <summary>
    /// Represents a model for managing and storing translation data organized by category.
    /// </summary>
    public class TranslationModel
    {
        private readonly Dictionary<Category, SortedDictionary<string, Translation>> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationModel"/> class.
        /// </summary>
        public TranslationModel()
        {
        }

        /// <summary>
        /// Adds a translation to the translation model.
        /// </summary>
        /// <param name="translation">The translation object to be added.</param>
        /// <returns>A <see cref="HashSet{Language}"/> containing the languages associated with the translation if successfully added; otherwise, <c>null</c>.</returns>
        public HashSet<Language>? Add(Translation? translation)
        {
            Category? category = translation?.Category;
            if (category is null)
            {
                return null;
            }

            string? id = translation?.Id;
            if (id == null)
            {
                return null;
            }

            HashSet<Language>? languages = translation!.Languages;
            if (languages == null)
            {
                return null;
            }

            Dictionary<Language, string> dictionary = [];
            foreach (Language language in languages)
            {
                if (translation[language] is string translationText)
                {
                    dictionary[language] = translationText;
                }
            }

            return Add(category, id, dictionary);
        }

        /// <summary>
        /// Adds a translation entry for a specific language to the specified category and identifier.
        /// </summary>
        /// <param name="category">The category to which the translation is added.</param>
        /// <param name="id">The unique identifier for the translation entry.</param>
        /// <param name="language">The language of the translation text.</param>
        /// <param name="text">The translation text to be stored.</param>
        /// <returns><c>true</c> if the translation was successfully added; otherwise, <c>false</c>.</returns>
        public bool Add(Category? category, string? id, Language? language, string? text)
        {
            if (category is null || id is null || language is null || text is null)
            {
                return false;
            }

            HashSet<Language>? languages = Add(category, id, [new KeyValuePair<Language, string>(language, text)]);
            if (languages == null || languages.Count == 0)
            {
                return false;
            }

            return languages.Contains(language);
        }

        /// <summary>
        /// Adds a translation for the specified enumeration member in the given language.
        /// </summary>
        /// <param name="enum">The enumeration member to translate.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="text">The translated text content.</param>
        /// <returns>True if the translation was successfully added; otherwise, false.</returns>
        public bool Add(Enum? @enum, Language? language, string? text)
        {
            if (@enum == null || language is null)
            {
                return false;
            }

            return Add(Enums.Category.Enum, Core.Query.FullName(@enum), language, text);
        }

        private HashSet<Language>? Add(Category? category, string? id, IEnumerable<KeyValuePair<Language, string>> keyValuePairs)
        {
            if (category is null || id is null || keyValuePairs is null || !keyValuePairs.Any())
            {
                return null;
            }

            if (!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary is null)
            {
                sortedDictionary = [];
                dictionary[category] = sortedDictionary;
            }

            if (!sortedDictionary.TryGetValue(id, out Translation translation) || translation is null)
            {
                translation = new Translation(category, id);
                sortedDictionary[id] = translation;
            }

            HashSet<Language> result = [];
            foreach (KeyValuePair<Language, string> keyValuePair in keyValuePairs)
            {
                if (translation.Add(keyValuePair.Key, keyValuePair.Value))
                {
                    result.Add(keyValuePair.Key);
                }
            }

            return result;
        }

        /// <summary>
        /// Attempts to retrieve the translated text for a specified category, identifier, and language.
        /// </summary>
        /// <param name="category">The category of the translation.</param>
        /// <param name="id">The unique identifier for the translation entry.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="text">When this method returns, contains the translated text if found; otherwise, null.</param>
        /// <returns>True if the translated text was successfully retrieved; otherwise, false.</returns>
        public bool TryGetText(Category? category, string? id, Language? language, out string? text)
        {
            text = null;

            if (category is null || id is null || language is null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary is null)
            {
                return false;
            }

            if (!sortedDictionary.TryGetValue(id, out Translation translation) || translation is null)
            {
                return false;
            }

            return translation.TryGetText(language, out text);
        }

        /// <summary>
        /// Attempts to retrieve the translation text for a specified category, identifier, and language.
        /// </summary>
        /// <param name="category">The category of the translation.</param>
        /// <param name="id">The unique identifier of the translation entry.</param>
        /// <param name="language">The language code for the requested translation.</param>
        /// <param name="text">When this method returns, contains the retrieved translation text if successful; otherwise, null.</param>
        /// <returns>True if the translation text was successfully retrieved; otherwise, false.</returns>
        public bool TryGetText(string? category, string? id, string? language, out string? text)
        {
            text = null;

            if (category == null || id is null || language == null)
            {
                return false;
            }

            return TryGetText(new Category(category), id, new Language(language), out text);
        }

        /// <summary>
        /// Attempts to retrieve the identifier for a specific translation text within a given category and language.
        /// </summary>
        /// <param name="category">The category of the translation.</param>
        /// <param name="text">The translated text to search for.</param>
        /// <param name="language">The language associated with the translation.</param>
        /// <param name="id">When this method returns, contains the identifier of the translation if found; otherwise, null.</param>
        /// <param name="textComparisonType">The type of text comparison to perform.</param>
        /// <param name="caseSensitive">A value indicating whether the search is case-sensitive.</param>
        /// <returns>True if the identifier was successfully retrieved; otherwise, false.</returns>
        public bool TryGetId(string? category, string? text, string? language, out string? id, Core.Enums.TextComparisonType textComparisonType = Core.Enums.TextComparisonType.Equals, bool caseSensitive = true)
        {
            id = null;

            if (category is null || text == null || language == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary is null)
            {
                return false;
            }

            foreach (KeyValuePair<string, Translation> keyValuePair in sortedDictionary)
            {
                Translation translation = keyValuePair.Value;
                if (translation == null)
                {
                    continue;
                }

                if (Core.Query.Compare(translation[language], text, textComparisonType, caseSensitive))
                {
                    id = keyValuePair.Key;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to retrieve the identifier for a translation based on the specified category, text, and language.
        /// </summary>
        /// <param name="category">The category associated with the translation.</param>
        /// <param name="text">The translation text to search for.</param>
        /// <param name="language">The language of the translation.</param>
        /// <param name="id">When this method returns <see langword="true"/>, contains the identifier of the translation; otherwise, <see langword="null"/>.</param>
        /// <param name="textComparisonType">The type of text comparison to use.</param>
        /// <param name="caseSensitive">A value indicating whether the comparison should be case-sensitive.</param>
        /// <returns><see langword="true"/> if the identifier was successfully retrieved; otherwise, <see langword="false"/>.</returns>
        public bool TryGetId(Category? category, string? text, Language? language, out string? id, Core.Enums.TextComparisonType textComparisonType = Core.Enums.TextComparisonType.Equals, bool caseSensitive = true)
        {
            return TryGetId(category?.Name, text, language?.Name, out id, textComparisonType, caseSensitive);
        }

        /// <summary>
        /// Attempts to retrieve the translated text for a specified enumeration value in the given language.
        /// </summary>
        /// <param name="enum">The enumeration value to translate.</param>
        /// <param name="language">The identifier of the target language.</param>
        /// <param name="text">When this method returns <see langword="true"/>, contains the translated text; otherwise, <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the translation was successfully retrieved; otherwise, <see langword="false"/>.</returns>
        public bool TryGetText(Enum? @enum, string? language, out string? text)
        {
            text = null;

            if (@enum == null || language == null)
            {
                return false;
            }

            return TryGetText(new Category(Enums.Category.Enum), Core.Query.FullName(@enum), new Language(language), out text);
        }

        /// <summary>
        /// Attempts to retrieve an enum value of type <typeparamref name="T"/> that matches the specified translated text for a given language.
        /// </summary>
        /// <typeparam name="T">The enum type to be retrieved.</typeparam>
        /// <param name="text">The translated text to match against.</param>
        /// <param name="language">The language identifier used for the translation lookup.</param>
        /// <param name="enum">When this method returns, contains the matched enum value if successful; otherwise, the default value of type <typeparamref name="T"/>.</param>
        /// <param name="textComparisonType">The comparison strategy to use when matching the text.</param>
        /// <param name="caseSensitive">Indicates whether the text comparison should be case-sensitive.</param>
        /// <returns>True if a matching enum value was found; otherwise, false.</returns>
        public bool TryGetEnum<T>(string? text, string? language, out T? @enum, Core.Enums.TextComparisonType textComparisonType = Core.Enums.TextComparisonType.Equals, bool caseSensitive = true) where T : Enum
        {
            @enum = default;

            if (language == null)
            {
                return false;
            }

            foreach (T @enum_Temp in Enum.GetValues(typeof(T)))
            {
                if (!TryGetText(enum_Temp, language, out string? text_Temp))
                {
                    continue;
                }

                if (!Core.Query.Compare(text_Temp, text, textComparisonType, caseSensitive))
                {
                    continue;
                }

                @enum = @enum_Temp;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the collection of all categories currently stored in the translation model.
        /// </summary>
        public HashSet<Category> Categories
        {
            get
            {
                return [.. dictionary.Keys];
            }
        }

        /// <summary>
        /// Retrieves all unique languages associated with the translations stored in the model.
        /// </summary>
        /// <returns>A <see cref="HashSet{Language}"/> containing all identified languages.</returns>
        public HashSet<Language> GetLanguages()
        {
            HashSet<Language> result = [];
            foreach (SortedDictionary<string, Translation> sortedDictionary in dictionary.Values)
            {
                foreach (Translation translation in sortedDictionary.Values)
                {
                    HashSet<Language>? languages = translation?.Languages;
                    if (languages == null)
                    {
                        continue;
                    }

                    foreach (Language language in languages)
                    {
                        result.Add(language);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the set of languages associated with a specified translation category.
        /// </summary>
        /// <param name="category">The translation category to retrieve languages for.</param>
        /// <returns>A <see cref="HashSet{Language}"/> containing the available languages for the specified category, or <see langword="null"/> if the provided category is null.</returns>
        public HashSet<Language>? GetLanguages(Category? category)
        {
            if (category is null)
            {
                return null;
            }

            HashSet<Language> result = [];
            foreach (KeyValuePair<Category, SortedDictionary<string, Translation>> keyValuePair in dictionary)
            {
                if (category != keyValuePair.Key)
                {
                    continue;
                }

                foreach (Translation translation in keyValuePair.Value.Values)
                {
                    HashSet<Language>? languages = translation?.Languages;
                    if (languages == null)
                    {
                        continue;
                    }

                    foreach (Language language in languages)
                    {
                        result.Add(language);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the set of identifiers associated with the specified category.
        /// </summary>
        /// <param name="category">The category for which to retrieve identifiers.</param>
        /// <returns>A <see cref="HashSet{T}"/> containing the identifiers if the category exists; otherwise, <see langword="null"/>.</returns>
        public HashSet<string>? GetIds(Category? category)
        {
            if (category is null)
            {
                return null;
            }

            if (!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary == null)
            {
                return null;
            }

            return [.. sortedDictionary.Keys];
        }
    }
}