using System.Collections;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to retrieve the zero-based index of the specified <see cref="DependencyObject"/> relative to its parent's children in the logical tree.
        /// </summary>
        /// <param name="dependencyObject">The <see cref="DependencyObject"/> for which to determine the index.</param>
        /// <param name="index">When this method returns, contains the zero-based index of the object if found; otherwise, -1.</param>
        /// <returns>True if the index was successfully retrieved; otherwise, false.</returns>
        public static bool TryGetIndex(this DependencyObject dependencyObject, out int index)
        {
            index = -1;

            if (dependencyObject == null)
            {
                return false;
            }

            DependencyObject? dependencyObject_Parent = LogicalTreeHelper.GetParent(dependencyObject);
            if (dependencyObject_Parent == null)
            {
                return false;
            }

            IEnumerable childrens = LogicalTreeHelper.GetChildren(dependencyObject_Parent);
            if (childrens == null)
            {
                return false;
            }

            Type type = dependencyObject.GetType();

            index = 1;
            foreach (object children in childrens)
            {
                if (children?.GetType() != type)
                {
                    continue;
                }

                if (children == dependencyObject)
                {
                    return true;
                }

                index++;
            }

            return false;
        }

        /// <summary>
        /// Attempts to retrieve the index of the specified <see cref="System.Windows.Controls.DataGridColumn"/> within the provided <see cref="System.Windows.Controls.DataGrid"/>.
        /// </summary>
        /// <param name="dataGridColumn">The <see cref="System.Windows.Controls.DataGridColumn"/> to locate.</param>
        /// <param name="dataGrid">The <see cref="System.Windows.Controls.DataGrid"/> containing the columns.</param>
        /// <param name="index">When this method returns, contains the zero-based index of the column if found; otherwise, -1.</param>
        /// <returns><see langword="true"/> if the index was successfully retrieved; otherwise, <see langword="false"/>.</returns>
        public static bool TryGetIndex(this System.Windows.Controls.DataGridColumn? dataGridColumn, System.Windows.Controls.DataGrid? dataGrid, out int index)
        {
            index = -1;

            if (dataGridColumn is null || dataGrid is null)
            {
                return false;
            }

            Type type = dataGridColumn.GetType();

            index = 1;
            foreach (System.Windows.Controls.DataGridColumn dataGridColumn_Temp in dataGrid.Columns)
            {
                if (dataGridColumn?.GetType() != type)
                {
                    continue;
                }

                if (dataGridColumn == dataGridColumn_Temp)
                {
                    return true;
                }

                index++;
            }

            return false;
        }
    }
}