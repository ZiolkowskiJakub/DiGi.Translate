using DiGi.Translate.Classes;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Translates the specified window and its components using the provided translator instance.
        /// </summary>
        /// <param name="translator">The translator used to retrieve translated text.</param>
        /// <param name="window">The WPF window to translate.</param>
        /// <param name="includeNested">Indicates whether nested elements within the window should also be translated.</param>
        /// <returns>True if the translation was successfully applied; otherwise, false.</returns>
        public static bool TranslateWindow(this Translator? translator, Window? window, bool includeNested = true)
        {
            if (window == null || translator == null)
            {
                return false;
            }

            string? id = window.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string? text);
            if (!result)
            {
                return result;
            }

            result = false;

            if (text is not null)
            {
                window.SetText(text);
                result = true;
            }

            if (!includeNested)
            {
                return result;
            }

            List<FrameworkElement>? frameworkElements_Nested = Query.DependencyObjects<FrameworkElement>(window);
            if (frameworkElements_Nested != null)
            {
                foreach (FrameworkElement frameworkElement_Nested in frameworkElements_Nested)
                {
                    TranslateFrameworkElement(translator, frameworkElement_Nested, includeNested);
                }
            }

            return result;
        }

        /// <summary>
        /// Translates the specified WPF window and its elements using the provided translation model and language.
        /// </summary>
        /// <param name="translationModel">The translation model used to retrieve localized text.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="window">The WPF window instance to translate.</param>
        /// <param name="includeNested">A value indicating whether to recursively translate nested framework elements within the window.</param>
        /// <returns>True if the window was successfully translated; otherwise, false.</returns>
        public static bool TranslateWindow(this TranslationModel? translationModel, Language? language, Window? window, bool includeNested = true)
        {
            if (window == null || translationModel == null)
            {
                return false;
            }

            string? id = window.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translationModel.TryGetText(Enums.Category.Control, id, language, out string? text);
            if (result)
            {
                result = false;
                if (text is not null)
                {
                    window.SetText(text);
                    result = true;
                }
            }

            if (!includeNested)
            {
                return result;
            }

            List<FrameworkElement>? frameworkElements_Nested = Query.DependencyObjects<FrameworkElement>(window);
            if (frameworkElements_Nested != null)
            {
                foreach (FrameworkElement frameworkElement_Nested in frameworkElements_Nested)
                {
                    bool translated = TranslateFrameworkElement(translationModel, language, frameworkElement_Nested, includeNested);
                    if (translated)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}