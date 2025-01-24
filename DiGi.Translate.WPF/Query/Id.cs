using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        public static string Id(this Control control)
        {
            if (control == null)
            {
                return null;
            }

            string result = control.Name;
            if(string.IsNullOrWhiteSpace(result))
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

        public static string? Id(this DependencyObject dependencyObject)
        {
            if(dependencyObject == null)
            {
                return null;
            }

            string? result = (dependencyObject as FrameworkElement)?.Name;
            if(string.IsNullOrWhiteSpace(result))
            {
                result = dependencyObject.GetType().Name;
                if(TryGetIndex(dependencyObject, out int index))
                {
                    result = string.Format("{0}_{1}", result, index);
                }
            }

            DependencyObject? dependencyObject_Parent = LogicalTreeHelper.GetParent(dependencyObject);
            if(dependencyObject_Parent != null)
            {
                string? id = dependencyObject_Parent.Id();
                if (!string.IsNullOrEmpty(id))
                {
                    result = string.IsNullOrWhiteSpace(result) ? id : string.Format("{0}.{1}", id, result);
                }
            }

            return result;
        }

        public static string? Id(this DataGridViewColumn dataGridViewColumn)
        {
            if (dataGridViewColumn == null) 
            {
                return null;
            }

            string id = Id(dataGridViewColumn.DataGridView);

            return string.IsNullOrEmpty(id) ? dataGridViewColumn.Name : string.Format("{0}.{1}", id, dataGridViewColumn.Name);
        }

        public static string? Id(this System.Windows.Controls.DataGridColumn dataGridColumn, System.Windows.Controls.DataGrid dataGrid)
        {
            if(dataGridColumn == null)
            {
                return null;
            }

            string? id = dataGrid?.Id();
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            if(!TryGetIndex(dataGridColumn, dataGrid, out int index) || index == -1)
            {
                index = dataGridColumn.DisplayIndex;
            }

            return string.Format("{0}.{1}_{2}", id, dataGridColumn.GetType().Name, index);


        }
    }
}
