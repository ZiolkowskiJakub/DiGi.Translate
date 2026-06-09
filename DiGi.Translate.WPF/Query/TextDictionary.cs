using System.Collections.ObjectModel;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts a dictionary of text entries from the specified dependency object and its descendants of type <typeparamref name="TDependencyObject"/>.
        /// </summary>
        /// <typeparam name="TDependencyObject">The type of dependency objects to be queried for text.</typeparam>
        /// <param name="dependencyObject">The root dependency object from which to extract the text dictionary.</param>
        /// <returns>A dictionary containing the extracted text entries, or null if the specified dependency object is null or no matching descendants are found.</returns>
        public static Dictionary<string, string?>? TextDictionary<TDependencyObject>(this DependencyObject? dependencyObject) where TDependencyObject : DependencyObject
        {
            if (dependencyObject == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = [];

            List<TDependencyObject>? dependencyObjects = DependencyObjects<TDependencyObject>(dependencyObject, true);
            if (dependencyObjects == null)
            {
                return null;
            }

            foreach (TDependencyObject dependencyObject_Temp in dependencyObjects)
            {
                string? id = dependencyObject_Temp?.Id();
                if (id == null)
                {
                    continue;
                }

                result[id] = dependencyObject_Temp?.Text();

                if (dependencyObject_Temp is System.Windows.Controls.DataGrid)
                {
                    Dictionary<string, string?>? dictionary = TextDictionary((System.Windows.Controls.DataGrid)(object)dependencyObject_Temp);
                    if (dictionary != null)
                    {
                        foreach (KeyValuePair<string, string?> keyValuePair in dictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts a dictionary of text values from the specified control and its descendants of type <typeparamref name="TControl"/>.
        /// </summary>
        /// <typeparam name="TControl">The type of controls to search for within the control hierarchy.</typeparam>
        /// <param name="control">The source control to analyze.</param>
        /// <returns>A dictionary containing the extracted text keys and values, or null if the control is null or no matching descendants are found.</returns>
        public static Dictionary<string, string?>? TextDictionary<TControl>(this Control? control) where TControl : Control
        {
            if (control == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = [];

            List<TControl>? controls = Controls<TControl>(control);
            if (controls == null)
            {
                return null;
            }

            foreach (TControl control_Temp in controls)
            {
                string? id = control_Temp?.Id();
                if (id == null)
                {
                    continue;
                }

                result[id] = control_Temp?.Text;

                if (control_Temp is DataGridView)
                {
                    Dictionary<string, string?>? dictionary = TextDictionary((DataGridView)(object)control_Temp);
                    if (dictionary != null)
                    {
                        foreach (KeyValuePair<string, string?> keyValuePair in dictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts a dictionary of text values from the columns of the specified <see cref="DataGridView"/>.
        /// </summary>
        /// <param name="dataGridView">The <see cref="DataGridView"/> to process.</param>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> mapping column identifiers to their text values, or <c>null</c> if the <paramref name="dataGridView"/> is null or contains no columns.</returns>
        public static Dictionary<string, string?>? TextDictionary(this DataGridView? dataGridView)
        {
            DataGridViewColumnCollection? dataGridViewColumnCollection = dataGridView?.Columns;

            if (dataGridViewColumnCollection == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = [];
            foreach (DataGridViewColumn dataGridViewColumn in dataGridViewColumnCollection)
            {
                string? id = dataGridViewColumn?.Id();
                if (string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                result[id] = dataGridViewColumn!.HeaderText;
            }

            return result;
        }

        /// <summary>
        /// Extracts a dictionary of column identifiers and their associated text from the specified <see cref="System.Windows.Controls.DataGrid"/>.
        /// </summary>
        /// <param name="dataGrid">The <see cref="System.Windows.Controls.DataGrid"/> to extract text from.</param>
        /// <returns>A dictionary mapping column IDs to their display text, or <c>null</c> if the <paramref name="dataGrid"/> is null or contains no columns.</returns>
        public static Dictionary<string, string?>? TextDictionary(this System.Windows.Controls.DataGrid? dataGrid)
        {
            ObservableCollection<System.Windows.Controls.DataGridColumn>? dataGridColumns = dataGrid?.Columns;
            if (dataGridColumns == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = [];
            foreach (System.Windows.Controls.DataGridColumn dataGridColumn in dataGridColumns)
            {
                string? id = dataGridColumn?.Id(dataGrid!);
                if (string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                result[id] = dataGridColumn!.Text();
            }

            return result;
        }
    }
}