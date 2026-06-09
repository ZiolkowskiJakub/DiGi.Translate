using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
    {
        /// <summary>
        /// Translates the specified framework element using the provided translator.
        /// </summary>
        /// <param name="translator">The <see cref="Translator"/> instance used to retrieve translation strings.</param>
        /// <param name="frameworkElement">The <see cref="FrameworkElement"/> to be translated.</param>
        /// <param name="includeNested">A value indicating whether to recursively translate nested child elements.</param>
        /// <returns><see langword="true"/> if the element was successfully translated; otherwise, <see langword="false"/>.</returns>
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

            List<FrameworkElement> frameworkElements_Nested = Query.DependencyObjects<FrameworkElement>(frameworkElement);
            if (frameworkElements_Nested != null)
            {
                foreach (FrameworkElement frameworkElement_Nested in frameworkElements_Nested)
                {
                    TranslateFrameworkElement(translator, frameworkElement_Nested, includeNested);
                }
            }

            return result;
        }

        /// <summary>
        /// Translates the specified <see cref="FrameworkElement"/> using the provided translation model and language.
        /// </summary>
        /// <param name="translationModel">The translation model used to retrieve translated text.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="frameworkElement">The framework element to translate.</param>
        /// <param name="includeNested">A value indicating whether to recursively translate nested child elements.</param>
        /// <returns><see langword="true"/> if the element was successfully translated; otherwise, <see langword="false"/>.</returns>
        public static bool TranslateFrameworkElement(this TranslationModel translationModel, Language language, FrameworkElement frameworkElement, bool includeNested = true)
        {
            if (frameworkElement == null || translationModel == null)
            {
                return false;
            }

            string id;

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

            List<FrameworkElement> frameworkElements_Nested = Query.DependencyObjects<FrameworkElement>(frameworkElement);
            if (frameworkElements_Nested != null)
            {
                foreach (FrameworkElement frameworkElement_Nested in frameworkElements_Nested)
                {
                    bool translated = TranslateFrameworkElement(translationModel, language, frameworkElement_Nested, includeNested);
                    if (translated)
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

        /// <summary>
        /// Translates the specified framework element into the target language using the provided translation model.
        /// </summary>
        /// <param name="translationModel">The translation model used to retrieve translated text.</param>
        /// <param name="language">The target language for the translation.</param>
        /// <param name="frameworkElement">The framework element to translate.</param>
        /// <param name="includeNested">A value indicating whether to recursively translate nested child elements.</param>
        /// <returns>True if the translation process was successful; otherwise, false.</returns>
        public static bool TranslateFrameworkElement(this TranslationModel translationModel, Enums.Language language, FrameworkElement frameworkElement, bool includeNested = true)
        {
            return TranslateFrameworkElement(translationModel, (Language)language, frameworkElement, includeNested);
        }
    }
}