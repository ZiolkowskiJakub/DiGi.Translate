using DiGi.Translate.Classes;
using System;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds all members of the specified enumeration to the translation model for the given language.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="translationModel">The translation model to which the enum values will be added.</param>
        /// <param name="language">The target language for the translations.</param>
        /// <param name="func">An optional function used to determine the text value for each enumeration member; defaults to retrieving the description if not provided.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public static bool AddEnum<T>(this TranslationModel? translationModel, Language? language, Func<T?, string?>? func = null) where T : Enum
        {
            if (translationModel == null || language is null)
            {
                return false;
            }

            func ??= x => Core.Query.Description(x);

            bool result = false;
            foreach (T value in Enum.GetValues(typeof(T)))
            {
                string? text = func.Invoke(value);

                if (translationModel.Add(value, language, text))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}