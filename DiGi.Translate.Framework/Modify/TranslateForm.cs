using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
    {
        /// <summary>
        /// Translates the specified form using the provided translator instance.
        /// </summary>
        /// <param name="translator">The <see cref="Translator"/> used to retrieve translated text.</param>
        /// <param name="form">The <see cref="Form"/> to be translated.</param>
        /// <param name="includeNested">A value indicating whether nested controls within the form should also be translated. Defaults to <c>true</c>.</param>
        /// <returns><c>true</c> if the form was successfully translated; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        /// Translates the specified form using the provided translation model and target language.
        /// </summary>
        /// <param name="translationModel">The translation model used to retrieve localized strings.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="form">The form instance to be translated.</param>
        /// <param name="includeNested">A value indicating whether nested controls within the form should also be translated.</param>
        /// <returns>True if the form was successfully translated; otherwise, false.</returns>
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