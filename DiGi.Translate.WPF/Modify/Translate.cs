using DiGi.Translate.Classes;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        public static bool Translate(this TranslationModel translationModel, Language language, Control control, bool includeNested = true)
        {
            if (translationModel == null || control == null || language == null)
            {
                return false;
            }

            bool result = false;
            if(translationModel.TryGetText(Enums.Category.Control, control.Id(), language, out string text))
            {
                control.Text = text;
                result = true;
            }

            if(includeNested)
            {
                List<Control> controls_Nested = control.Controls<Control>();
                if(controls_Nested != null)
                {
                    foreach(Control control_Nested in controls_Nested)
                    {
                        bool result_Nested = Translate(translationModel, language, control_Nested, includeNested);
                        if(result_Nested)
                        {
                            result = true;
                        }
                    }
                }
            }

            return result;
        }

        public static bool Translate(this TranslationModel translationModel, Enums.Language language, Control control, bool includeNested = true)
        {
            return Translate(translationModel, (Language)language, control, includeNested);
        }
    }
}
