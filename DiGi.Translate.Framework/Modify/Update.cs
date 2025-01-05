using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
    {
        public static bool Update(this TranslationModel translationModel, Form form, Language language)
        {
            if(translationModel == null || form == null)
            {
                return false;
            }

            List<Control> controls = form.Controls();
            if(controls == null || controls.Count == 0)
            {
                return false;
            }

            bool result = false;
            foreach(Control control in controls)
            {
                string id = control.Id();
                if(string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                translationModel.Add(Enums.Category.Control, id, language, control.Text);
            }

            return result;
        }
    }
}
