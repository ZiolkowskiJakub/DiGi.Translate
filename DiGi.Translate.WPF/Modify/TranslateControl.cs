using DiGi.Translate.Classes;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        /// <summary>
        /// Translates the specified WPF control using the provided translator instance.
        /// </summary>
        /// <param name="translator">The <see cref="Translator"/> used to retrieve translated text.</param>
        /// <param name="control">The <see cref="Control"/> to be translated.</param>
        /// <param name="includeNested">A value indicating whether the translation should be applied recursively to nested child controls.</param>
        /// <returns><see langword="true"/> if the control was successfully translated; otherwise, <see langword="false"/>.</returns>
        public static bool TranslateControl(this Translator? translator, Control? control, bool includeNested = true)
        {
            if (control == null || translator == null)
            {
                return false;
            }

            string? id = control.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string? text);
            if (!result)
            {
                return result;
            }

            control.Text = text;

            if (!includeNested)
            {
                return result;
            }

            List<Control>? controls_Nested = Query.Controls<Control>(control);
            if (controls_Nested != null)
            {
                foreach (Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
                }
            }

            if (control is DataGridView dataGridView)
            {
                DataGridViewColumnCollection? dataGridViewColumnCollection = dataGridView?.Columns;
                if (dataGridViewColumnCollection != null)
                {
                    foreach (DataGridViewColumn dataGridViewColumn in dataGridViewColumnCollection)
                    {
                        if (!translator.TryGetText(Enums.Category.Control, dataGridViewColumn.Id(), out text))
                        {
                            continue;
                        }

                        dataGridViewColumn.HeaderText = text;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Translates the text of a specified control using the provided translation model and language.
        /// </summary>
        /// <param name="translationModel">The translation model used to retrieve translated text.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="control">The control whose text is to be translated.</param>
        /// <param name="includeNested">A value indicating whether to translate nested controls within the specified control.</param>
        /// <returns>True if the control was successfully translated; otherwise, false.</returns>
        public static bool TranslateControl(this TranslationModel? translationModel, Language? language, Control? control, bool includeNested = true)
        {
            if (translationModel is null || control is null || language is null)
            {
                return false;
            }

            bool result = false;
            if (translationModel.TryGetText(Enums.Category.Control, control.Id(), language, out string? text))
            {
                control.Text = text;
                result = true;
            }

            if (!includeNested)
            {
                return result;
            }

            List<Control>? controls_Nested = Query.Controls<Control>(control);
            if (controls_Nested != null)
            {
                foreach (Control control_Nested in controls_Nested)
                {
                    bool result_Nested = TranslateControl(translationModel, language, control_Nested, includeNested);
                    if (result_Nested)
                    {
                        result = true;
                    }
                }
            }

            if (control is DataGridView dataGridView)
            {
                DataGridViewColumnCollection? dataGridViewColumnCollection = dataGridView?.Columns;
                if (dataGridViewColumnCollection != null)
                {
                    foreach (DataGridViewColumn dataGridViewColumn in dataGridViewColumnCollection)
                    {
                        if (!translationModel.TryGetText(Enums.Category.Control, dataGridViewColumn.Id(), language, out text))
                        {
                            continue;
                        }

                        dataGridViewColumn.HeaderText = text;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Translates the specified WPF control and optionally its nested children using the provided translation model and language.
        /// </summary>
        /// <param name="translationModel">The translation model containing the localized strings.</param>
        /// <param name="language">The target language to apply for the translation.</param>
        /// <param name="control">The WPF control to be translated.</param>
        /// <param name="includeNested">A value indicating whether to recursively translate nested controls within the specified control.</param>
        /// <returns>True if the translation process was successful; otherwise, false.</returns>
        public static bool TranslateControl(this TranslationModel? translationModel, Enums.Language language, Control? control, bool includeNested = true)
        {
            return TranslateControl(translationModel, (Language)language, control, includeNested);
        }
    }
}