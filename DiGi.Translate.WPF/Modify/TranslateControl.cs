using DiGi.Translate.Classes;
using System.Collections.ObjectModel;
using System.Windows;

namespace DiGi.Translate.WPF
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

            if (!includeNested)
            {
                return result;
            }

            List<Control> controls_Nested = Query.Controls<Control>(control);
            if (controls_Nested != null)
            {
                foreach (Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
                }
            }

            if (control is DataGridView)
            {
                DataGridViewColumnCollection dataGridViewColumnCollection = ((DataGridView)control)?.Columns;
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

        public static bool TranslateControl(this TranslationModel translationModel, Language language, Control control, bool includeNested = true)
        {
            if (translationModel == null || control == null || language == null)
            {
                return false;
            }

            bool result = false;
            if (translationModel.TryGetText(Enums.Category.Control, control.Id(), language, out string text))
            {
                control.Text = text;
                result = true;
            }

            if (!includeNested)
            {
                return result;
            }

            List<Control> controls_Nested = Query.Controls<Control>(control);
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

            if (control is DataGridView)
            {
                DataGridViewColumnCollection dataGridViewColumnCollection = ((DataGridView)control)?.Columns;
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

        public static bool TranslateControl(this TranslationModel translationModel, Enums.Language language, Control control, bool includeNested = true)
        {
            return TranslateControl(translationModel, (Language)language, control, includeNested);
        }
    }
}
