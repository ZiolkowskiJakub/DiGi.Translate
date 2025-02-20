using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
    {
        public static bool TranslateForm(this Translator translator, Form form, bool includeNested = true)
        {
            if (form == null || translator == null)
            {
                return false;
            }

            string id = form.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string text);
            if (!result)
            {
                return result;
            }

            form.Text = text;

            if (!includeNested)
            {
                return result;
            }

            List<Control> controls = form.Controls();
            if (controls != null)
            {
                foreach (Control control in controls)
                {
                    bool translated = TranslateControl(translator, control, includeNested);
                    if (translated)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public static bool TranslateForm(this TranslationModel translationModel, Language language, Form form, bool includeNested = true)
        {
            if (form == null || translationModel == null)
            {
                return false;
            }

            string id = form.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translationModel.TryGetText(Enums.Category.Control, id, language, out string text);
            if (result)
            {
                form.Text = text;
            }

            if (!includeNested)
            {
                return result;
            }



            List<Control> controls = form.Controls();
            if (controls != null)
            {
                foreach (Control control in controls)
                {
                    bool translated = TranslateControl(translationModel, language, control, includeNested);
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
