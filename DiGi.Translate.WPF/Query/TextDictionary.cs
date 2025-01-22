using System.Collections.ObjectModel;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        public static Dictionary<string, string?>? TextDictionary<TDependencyObject>(this DependencyObject dependencyObject) where TDependencyObject : DependencyObject
        {
            if(dependencyObject == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = new Dictionary<string, string?>();

            List<TDependencyObject>? dependencyObjects = DependencyObjects<TDependencyObject>(dependencyObject, true);
            if(dependencyObjects == null)
            {
                return null;
            }

            foreach (TDependencyObject dependencyObject_Temp in dependencyObjects)
            {
                string? id = dependencyObject_Temp?.Id();
                if(id == null)
                {
                    continue;
                }

                result[id] = dependencyObject_Temp?.Text();

                if(dependencyObject_Temp is System.Windows.Controls.DataGrid)
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

        public static Dictionary<string, string?>? TextDictionary<TControl>(this Control control) where TControl : Control
        {
            if (control == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = new Dictionary<string, string?>();

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

                if(control_Temp is DataGridView)
                {
                    Dictionary<string, string?>? dictionary = TextDictionary((DataGridView)(object)control_Temp);
                    if(dictionary != null)
                    {
                        foreach(KeyValuePair<string, string?> keyValuePair in dictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        public static Dictionary<string, string?>? TextDictionary(this DataGridView dataGridView)
        {
            DataGridViewColumnCollection? dataGridViewColumnCollection = dataGridView?.Columns;

            if(dataGridViewColumnCollection == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = new Dictionary<string, string?>();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridViewColumnCollection)
            {
                string? id = dataGridViewColumn?.Id();
                if(string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                result[id] = dataGridViewColumn.HeaderText;

            }

            return result;
        }

        public static Dictionary<string, string?>? TextDictionary(this System.Windows.Controls.DataGrid dataGrid)
        {
            ObservableCollection<System.Windows.Controls.DataGridColumn> dataGridColumns = dataGrid?.Columns;

            if (dataGridColumns == null)
            {
                return null;
            }

            Dictionary<string, string?>? result = new Dictionary<string, string?>();
            foreach (System.Windows.Controls.DataGridColumn dataGridColumn in dataGridColumns)
            {
                string id = dataGridColumn?.Id(dataGrid);
                if (string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                result[id] = dataGridColumn.Text();
            }

            return result;
        }
    }
}