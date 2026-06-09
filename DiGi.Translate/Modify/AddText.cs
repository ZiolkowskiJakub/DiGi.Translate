using DiGi.Translate.Classes;
using System;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a text entry to the specified translation model for the given language.
        /// </summary>
        /// <param name="translationModel">The translation model instance to which the text will be added.</param>
        /// <param name="language">The target language for the translation entry.</param>
        /// <param name="text">The text content to be added.</param>
        /// <param name="func">An optional transformation function to apply to the text before adding it.</param>
        /// <returns><see langword="true"/> if the text was successfully added; otherwise, <see langword="false"/>.</returns>
        public static bool AddText(this TranslationModel? translationModel, Language? language, string? text, Func<string?, string?>? func = null)
        {
            if (translationModel is null || language is null)
            {
                return false;
            }

            func ??= x => x;

            return translationModel.Add(new Category(Enums.Category.Text), func.Invoke(text), language, text);
        }
    }
}