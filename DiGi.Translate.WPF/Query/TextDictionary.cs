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
            }

            return result;
        }
    }
}