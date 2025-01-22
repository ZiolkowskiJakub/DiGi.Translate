using DiGi.Translate.Classes;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        public static bool TranslateWindow(this Translator translator, System.Windows.Window window, bool includeNested = true)
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

            List<System.Windows.Controls.Control>? controls_Nested = Query.DependencyObjects<System.Windows.Controls.Control>(window);
            if (controls_Nested != null)
            {
                foreach (System.Windows.Controls.Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
                }
            }

            return result;
        }

        public static bool TranslateWindow(this TranslationModel translationModel, Language language, System.Windows.Window window, bool includeNested = true)
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

            bool result = translationModel.TryGetText(Enums.Category.Control, id, out string text);
            if (result)
            {
                window.SetText(text);
            }

            if (!includeNested)
            {
                return result;
            }

            List<System.Windows.Controls.Control>? controls_Nested = Query.DependencyObjects<System.Windows.Controls.Control>(window);
            if (controls_Nested != null)
            {
                foreach (System.Windows.Controls.Control control_Nested in controls_Nested)
                {
                    bool translated = TranslateControl(translationModel, language, control_Nested, includeNested);
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
