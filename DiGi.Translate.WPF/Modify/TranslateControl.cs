using DiGi.Translate.Classes;
using System.Collections.ObjectModel;

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

            List<System.Windows.Controls.Control>? controls_Nested = Query.DependencyObjects<System.Windows.Controls.Control>(control);
            if (controls_Nested != null)
            {
                foreach (System.Windows.Controls.Control control_Nested in controls_Nested)
                {
                    TranslateControl(translator, control_Nested, includeNested);
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

        public static bool TranslateControl(this TranslationModel translationModel, Language language, System.Windows.Controls.Control control, bool includeNested = true)
        {
            if (control == null || translationModel == null)
            {
                return false;
            }

            string? id;

            id = control.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translationModel.TryGetText(Enums.Category.Control, id, language, out string text);
            if (result)
            {
                control.SetText(text);
            }

            if (!includeNested)
            {
                return result;
            }

            List<System.Windows.Controls.Control>? controls_Nested = Query.DependencyObjects<System.Windows.Controls.Control>(control);
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

            if (control is System.Windows.Controls.DataGrid)
            {
                System.Windows.Controls.DataGrid dataGrid = (System.Windows.Controls.DataGrid)(object)control;

                ObservableCollection<System.Windows.Controls.DataGridColumn> dataGridColumns = dataGrid?.Columns;
                if (dataGridColumns != null)
                {
                    foreach (System.Windows.Controls.DataGridColumn dataGridColumn in dataGridColumns)
                    {
                        id = dataGridColumn.Id(dataGrid);
                        if (string.IsNullOrWhiteSpace(id))
                        {
                            continue;
                        }

                        if (!translationModel.TryGetText(Enums.Category.Control, id, language, out text))
                        {
                            continue;
                        }

                        dataGridColumn.SetText(text);
                    }
                }
            }

            return result;
        }

        public static bool TranslateControl(this TranslationModel translationModel, Enums.Language language, System.Windows.Controls.Control control, bool includeNested = true)
        {
            return TranslateControl(translationModel, (Language)language, control, includeNested);
        }
    }
}
