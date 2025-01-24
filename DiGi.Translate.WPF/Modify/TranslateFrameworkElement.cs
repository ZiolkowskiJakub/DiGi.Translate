using DiGi.Translate.Classes;
using System.Collections.ObjectModel;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Modify
    {
        public static bool TranslateFrameworkElement(this Translator translator, FrameworkElement frameworkElement, bool includeNested = true)
        {
            if (frameworkElement == null || translator == null)
            {
                return false;
            }

            string id = frameworkElement.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translator.TryGetText(Enums.Category.Control, id, out string text);
            if (!result)
            {
                return result;
            }

            frameworkElement.SetText(text);

            if (!includeNested)
            {
                return result;
            }

            List<FrameworkElement>? frameworkElements_Nested = Query.DependencyObjects<FrameworkElement>(frameworkElement);
            if (frameworkElements_Nested != null)
            {
                foreach (FrameworkElement frameworkElement_Nested in frameworkElements_Nested)
                {
                    TranslateFrameworkElement(translator, frameworkElement_Nested, includeNested);
                }
            }

            return result;
        }

        public static bool TranslateFrameworkElement(this TranslationModel translationModel, Language language, FrameworkElement frameworkElement, bool includeNested = true)
        {
            if (frameworkElement == null || translationModel == null)
            {
                return false;
            }

            string? id;

            id = frameworkElement.Id();
            if (id == null)
            {
                return false;
            }

            bool result = translationModel.TryGetText(Enums.Category.Control, id, language, out string text);
            if (result)
            {
                frameworkElement.SetText(text);
            }

            if (!includeNested)
            {
                return result;
            }

            List<FrameworkElement>? frameworkElements_Nested = Query.DependencyObjects<FrameworkElement>(frameworkElement);
            if (frameworkElements_Nested != null)
            {
                foreach (FrameworkElement frameworkElement_Nested in frameworkElements_Nested)
                {
                    bool translated = TranslateFrameworkElement(translationModel, language, frameworkElement_Nested, includeNested);
                    if(translated)
                    {
                        result = true;
                    }
                }
            }

            if (frameworkElement is System.Windows.Controls.DataGrid)
            {
                System.Windows.Controls.DataGrid dataGrid = (System.Windows.Controls.DataGrid)(object)frameworkElement;

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

        public static bool TranslateFrameworkElement(this TranslationModel translationModel, Enums.Language language, FrameworkElement frameworkElement, bool includeNested = true)
        {
            return TranslateFrameworkElement(translationModel, (Language)language, frameworkElement, includeNested);
        }
    }
}
