using System.Windows;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a unique identifier for the specified dependency object based on its name, type, and index.
        /// </summary>
        /// <param name="dependencyObject">The dependency object to identify.</param>
        /// <returns>A string representing the identifier of the dependency object, or null if the provided object is null.</returns>
        public static string Id(this DependencyObject dependencyObject)
        {
            if (dependencyObject == null)
            {
                return null;
            }

            string result = (dependencyObject as FrameworkElement)?.Name;
            if (string.IsNullOrWhiteSpace(result))
            {
                result = dependencyObject.GetType().Name;
                if (TryGetIndex(dependencyObject, out int index))
                {
                    result = string.Format("{0}_{1}", result, index);
                }
            }

            DependencyObject dependencyObject_Parent = LogicalTreeHelper.GetParent(dependencyObject);
            if (dependencyObject_Parent != null)
            {
                string id = dependencyObject_Parent.Id();
                if (!string.IsNullOrEmpty(id))
                {
                    result = string.IsNullOrWhiteSpace(result) ? id : string.Format("{0}.{1}", id, result);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the identifier for the specified control, incorporating the control's name or type and its hierarchical path.
        /// </summary>
        /// <param name="control">The control for which to retrieve the identifier.</param>
        /// <returns>The identifier of the control as a string, or null if the control is null.</returns>
        public static string Id(this Control control)
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
                string id = control.Parent.Id();
                if (!string.IsNullOrEmpty(id))
                {
                    result = string.Format("{0}.{1}", id, result);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the unique identifier for the specified <see cref="System.Windows.Forms.DataGridViewColumn"/>.
        /// </summary>
        /// <param name="dataGridViewColumn">The data grid view column to identify.</param>
        /// <returns>The unique identifier of the column, or null if the provided column is null.</returns>
        public static string Id(this DataGridViewColumn dataGridViewColumn)
        {
            if (dataGridViewColumn == null)
            {
                return null;
            }

            string id = Id(dataGridViewColumn.DataGridView);

            return string.IsNullOrEmpty(id) ? dataGridViewColumn.Name : string.Format("{0}.{1}", id, dataGridViewColumn.Name);
        }

        /// <summary>
        /// Gets the unique identifier for the specified <see cref="System.Windows.Controls.DataGridColumn"/> within the provided <see cref="System.Windows.Controls.DataGrid"/>.
        /// </summary>
        /// <param name="dataGridColumn">The data grid column to identify.</param>
        /// <param name="dataGrid">The data grid containing the column.</param>
        /// <returns>A string representing the unique identifier of the column, or <c>null</c> if the identifier cannot be determined.</returns>
        public static string Id(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid)
        {
            if (dataGridColumn == null)
            {
                return null;
            }

            string id = dataGrid?.Id();
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