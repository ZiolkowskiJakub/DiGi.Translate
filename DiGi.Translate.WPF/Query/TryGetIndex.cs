using System.Collections;
using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        public static bool TryGetIndex(this DependencyObject dependencyObject, out int index)
        {
            index = -1;

            if(dependencyObject == null)
            {
                return false;
            }

            DependencyObject? dependencyObject_Parent = LogicalTreeHelper.GetParent(dependencyObject);
            if(dependencyObject_Parent == null)
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
            foreach(object children in childrens)
            {
                if (children?.GetType() != type)
                {
                    continue;
                }

                if(children == dependencyObject)
                {
                    return true;
                }

                index++;
            }

            return false;
        }

        public static bool TryGetIndex(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid, out int index)
        {
            index = -1;

            if (dataGridColumn == null)
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

