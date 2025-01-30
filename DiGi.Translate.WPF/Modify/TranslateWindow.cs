using DiGi.Translate.Classes;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        public static bool TranslateWindow(this Translator translator, Window window, bool includeNested = true)
        {
            if (window == null || translator == null)
            {
                return false;
            }

            string id = window.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string text);
            if (!result)
            {
                return result;
            }

            window.SetText(text);

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

        public static bool TranslateWindow(this TranslationModel translationModel, Language language, Window window, bool includeNested = true)
        {
            if (window == null || translationModel == null)
            {
                return false;
            }

            string id = window.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translationModel.TryGetText(Enums.Category.Control, id, language, out string text);
            if (result)
            {
                window.SetText(text);
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
                    if(translated)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}
