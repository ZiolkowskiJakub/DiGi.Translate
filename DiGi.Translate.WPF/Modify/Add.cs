using DiGi.Translate.Classes;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a translation entry for the specified WPF <see cref="DependencyObject"/> to the <see cref="TranslationModel"/>.
        /// </summary>
        /// <param name="translationModel">The <see cref="TranslationModel"/> instance where the translation will be added.</param>
        /// <param name="language">The target <see cref="Language"/> for the translation entry.</param>
        /// <param name="dependencyObject">The <see cref="DependencyObject"/> from which the identifier and text are extracted.</param>
        /// <param name="includeNullOrEmpty">A value indicating whether to include entries with null or empty text. Defaults to <c>false</c>.</param>
        /// <param name="includeNested">A value indicating whether to process nested child elements. Defaults to <c>true</c>.</param>
        /// <returns><c>true</c> if the translation was successfully processed; otherwise, <c>false</c>.</returns>
        public static bool Add(this TranslationModel translationModel, Language language, DependencyObject dependencyObject, bool includeNullOrEmpty = false, bool includeNested = true)
        {
            if (translationModel is null || language is null || dependencyObject is null)
            {
                return false;
            }

            string? id = dependencyObject.Id();
            if (id != null)
            {
                string? text = dependencyObject.Text();
                if (!(!includeNullOrEmpty && string.IsNullOrEmpty(text)))
                {
                    translationModel.Add(Enums.Category.Control, id, language, text);
                }
            }

            if (includeNested)
            {
                Dictionary<string, string?>? dictionary = Query.TextDictionary<FrameworkElement>(dependencyObject);
                if (dictionary != null)
                {
                    foreach (KeyValuePair<string, string?> keyValuePair in dictionary)
                    {
                        if (!includeNullOrEmpty && string.IsNullOrEmpty(keyValuePair.Value))
                        {
                            continue;
                        }

                        translationModel.Add(Enums.Category.Control, keyValuePair.Key, language, keyValuePair.Value);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Adds a translation entry for the specified control to the translation model.
        /// </summary>
        /// <param name="translationModel">The translation model to update.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="control">The control whose identifier and text are used for the translation entry.</param>
        /// <param name="includeNullOrEmpty">Indicates whether entries with null or empty text should be included.</param>
        /// <param name="includeNested">Indicates whether to recursively process nested controls.</param>
        /// <returns>True if the control was successfully processed; otherwise, false.</returns>
        public static bool Add(this TranslationModel translationModel, Language language, Control control, bool includeNullOrEmpty = false, bool includeNested = true)
        {
            if (translationModel is null || language is null || control is null)
            {
                return false;
            }

            string? id = control.Id();
            if (id != null)
            {
                string? text = control.Text;
                if (!(!includeNullOrEmpty && string.IsNullOrEmpty(text)))
                {
                    translationModel.Add(Enums.Category.Control, id, language, text);
                }
            }

            if (includeNested)
            {
                Dictionary<string, string?>? dictionary = Query.TextDictionary<Control>(control);
                if (dictionary != null)
                {
                    foreach (KeyValuePair<string, string?> keyValuePair in dictionary)
                    {
                        if (!includeNullOrEmpty && string.IsNullOrEmpty(keyValuePair.Value))
                        {
                            continue;
                        }

                        translationModel.Add(Enums.Category.Control, keyValuePair.Key, language, keyValuePair.Value);
                    }
                }

                if (control is DataGridView dataGridView)
                {
                    dictionary = Query.TextDictionary(dataGridView);
                    if (dictionary != null)
                    {
                        foreach (KeyValuePair<string, string?> keyValuePair in dictionary)
                        {
                            if (!includeNullOrEmpty && string.IsNullOrEmpty(keyValuePair.Value))
                            {
                                continue;
                            }

                            translationModel.Add(Enums.Category.Control, keyValuePair.Key, language, keyValuePair.Value);
                        }
                    }
                }
            }

            return true;
        }
    }
}