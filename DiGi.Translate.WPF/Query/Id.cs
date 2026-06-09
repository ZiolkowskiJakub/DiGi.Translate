using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a unique identifier for the specified WPF control, prioritizing its name and falling back to its type name.
        /// </summary>
        /// <param name="control">The control to retrieve the identifier from.</param>
        /// <returns>The identifier of the control, or null if the provided control is null.</returns>
        public static string? Id(this Control? control)
        {
            if (control == null)
            {
                return null;
            }

            string result = control.Name;
            if (string.IsNullOrWhiteSpace(result))
            {
                result = control.GetType().Name;
            }

            if (control.Parent != null)
            {
                string? id = control.Parent.Id();
                if (!string.IsNullOrEmpty(id))
                {
                    result = string.Format("{0}.{1}", id, result);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a unique identifier for the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="dependencyObject">The dependency object to evaluate.</param>
        /// <returns>The identifier string based on the element's name, type, or index; otherwise, <c>null</c>.</returns>
        public static string? Id(this DependencyObject? dependencyObject)
        {
            if (dependencyObject == null)
            {
                return null;
            }

            string? result = (dependencyObject as FrameworkElement)?.Name;
            if (string.IsNullOrWhiteSpace(result))
            {
                result = dependencyObject.GetType().Name;
                if (TryGetIndex(dependencyObject, out int index))
                {
                    result = string.Format("{0}_{1}", result, index);
                }
            }

            DependencyObject? dependencyObject_Parent = LogicalTreeHelper.GetParent(dependencyObject);
            if (dependencyObject_Parent != null)
            {
                string? id = dependencyObject_Parent.Id();
                if (!string.IsNullOrEmpty(id))
                {
                    result = string.IsNullOrWhiteSpace(result) ? id : string.Format("{0}.{1}", id, result);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the unique identifier for the specified <see cref="DataGridViewColumn"/>.
        /// </summary>
        /// <param name="dataGridViewColumn">The data grid column to identify.</param>
        /// <returns>The unique identifier of the column, or <see langword="null"/> if the provided column is null.</returns>
        public static string? Id(this DataGridViewColumn? dataGridViewColumn)
        {
            if (dataGridViewColumn == null)
            {
                return null;
            }

            string? id = Id(dataGridViewColumn.DataGridView);

            return string.IsNullOrEmpty(id) ? dataGridViewColumn.Name : string.Format("{0}.{1}", id, dataGridViewColumn.Name);
        }

        /// <summary>
        /// Retrieves the unique identifier for the specified data grid column within the provided data grid.
        /// </summary>
        /// <param name="dataGridColumn">The data grid column to identify.</param>
        /// <param name="dataGrid">The data grid containing the column.</param>
        /// <returns>The unique identifier of the column if successful; otherwise, <c>null</c>.</returns>
        public static string? Id(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid)
        {
            if (dataGridColumn == null)
            {
                return null;
            }

            string? id = dataGrid?.Id();
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            if (!TryGetIndex(dataGridColumn, dataGrid, out int index) || index == -1)
            {
                index = dataGridColumn.DisplayIndex;
            }

            return string.Format("{0}.{1}_{2}", id, dataGridColumn.GetType().Name, index);
        }
    }
}