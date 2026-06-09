using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a translation entry for the specified control to the translation model.
        /// </summary>
        /// <param name="translationModel">The <see cref="TranslationModel"/> instance to which the translation will be added.</param>
        /// <param name="language">The <see cref="Language"/> associated with the translation.</param>
        /// <param name="control">The <see cref="Control"/> whose text is to be extracted and translated.</param>
        /// <param name="includeNullOrEmpty">A value indicating whether controls with null or empty text should be included. Defaults to <c>false</c>.</param>
        /// <param name="includeNested">A value indicating whether nested child controls should also be processed. Defaults to <c>true</c>.</param>
        /// <returns><c>true</c> if the translation was successfully added; otherwise, <c>false</c>.</returns>
        public static bool Add(this TranslationModel translationModel, Language language, Control control, bool includeNullOrEmpty = false, bool includeNested = true)
        {
            if (translationModel == null || language == null || control == null)
            {
                return false;
            }

            string id = control.Id();
            if (id != null)
            {
                string text = control.Text;
                if (!(!includeNullOrEmpty && string.IsNullOrEmpty(text)))
                {
                    translationModel.Add(Enums.Category.Control, id, language, text);
                }
            }

            if (includeNested)
            {
                Dictionary<string, string> dictionary = Query.TextDictionary<Control>(control);
                if (dictionary != null)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in dictionary)
                    {
                        if (!includeNullOrEmpty && string.IsNullOrEmpty(keyValuePair.Value))
                        {
                            continue;
                        }

                        translationModel.Add(Enums.Category.Control, keyValuePair.Key, language, keyValuePair.Value);
                    }
                }

                if (control is DataGridView)
                {
                    dictionary = Query.TextDictionary((DataGridView)control);
                    if (dictionary != null)
                    {
                        foreach (KeyValuePair<string, string> keyValuePair in dictionary)
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