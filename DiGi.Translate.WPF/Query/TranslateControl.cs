using DiGi.Translate.Classes;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        public static bool TranslateControl(this Translator translator, Control control, bool includeNested = true)
        {
            if (control == null || translator == null)
            {
                return false;
            }

            string id = control.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string text);
            if (!result)
            {
                return result;
            }

            control.Text = text;

            if(!includeNested)
            {
                return result;
            }

            List<Control> controls_Nested = Controls<Control>(control);
            if(controls_Nested != null)
            {
                foreach(Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
                }
            }

            return result;
        }

        public static bool TranslateControl(this Translator translator, System.Windows.Controls.Control control, bool includeNested = true)
        {
            if (control == null || translator == null)
            {
                return false;
            }

            string id = control.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string text);
            if (!result)
            {
                return result;
            }

            control.SetText(text);

            if (!includeNested)
            {
                return result;
            }

            List<System.Windows.Controls.Control>? controls_Nested = DependencyObjects<System.Windows.Controls.Control>(control);
            if (controls_Nested != null)
            {
                foreach (System.Windows.Controls.Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
                }
            }

            return result;
        }
    }
}
