using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
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

            List<Control> controls_Nested = Query.Controls<Control>(control);
            if(controls_Nested != null)
            {
                foreach(Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
                }
            }

            return result;
        }
    }
}
