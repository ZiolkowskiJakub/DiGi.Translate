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
    }
}
