namespace DiGi.Translate.Classes
{
    /// <summary>
    /// Represents a translator that handles the localization of strings using a specified translation model and language.
    /// </summary>
    public class Translator
    {
        private readonly TranslationModel? translationModel;
        /// <summary>
        /// Gets or sets the current language used by the translator.
        /// </summary>
        public Language? Language { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Translator"/> class.
        /// </summary>
        /// <param name="translationModel">The translation model containing the localized strings.</param>
        /// <param name="language">The initial language to be used for translations.</param>
        public Translator(TranslationModel? translationModel, Language? language)
        {
            this.translationModel = translationModel;
            Language = language;
        }

        /// <summary>
        /// Attempts to retrieve the translated text for the specified category and identifier based on the current language.
        /// </summary>
        /// <param name="category">The translation category.</param>
        /// <param name="id">The unique identifier of the text to retrieve.</param>
        /// <param name="text">When this method returns, contains the translated text if found; otherwise, null.</param>
        /// <returns><see langword="true"/> if the translation was successfully retrieved; otherwise, <see langword="false"/>.</returns>
        public bool TryGetText(Category? category, string? id, out string? text)
        {
            text = null;

            if (translationModel is null || category is null || id is null)
            {
                return false;
            }

            return translationModel.TryGetText(category, id, Language, out text);
        }

        /// <summary>
        /// Attempts to retrieve the translated text associated with the specified category name and identifier.
        /// </summary>
        /// <param name="category">The name of the translation category.</param>
        /// <param name="id">The unique identifier for the text entry.</param>
        /// <param name="text">When this method returns, contains the translated text if found; otherwise, <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the translation was successfully retrieved; otherwise, <see langword="false"/>.</returns>
        public bool TryGetText(string? category, string? id, out string? text)
        {
            text = null;
            if (category is null || id is null)
            {
                return false;
            }

            return TryGetText(new Category(category), id, out text);
        }
    }
}