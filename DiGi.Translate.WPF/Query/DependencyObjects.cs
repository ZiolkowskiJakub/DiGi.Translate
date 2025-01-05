using System.Windows;


namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        //public static List<TDependencyObject>? DependencyObjects<TDependencyObject>(this Window window, bool includeNested = true) where TDependencyObject : DependencyObject
        //{
        //    return DependencyObjects<TDependencyObject>(window, includeNested);
        //}

        public static List<TDependencyObject>? DependencyObjects<TDependencyObject>(this DependencyObject dependencyObject, bool includeNested = true) where TDependencyObject : DependencyObject
        {
            System.Collections.IEnumerable childrens = LogicalTreeHelper.GetChildren(dependencyObject);
            if (childrens == null)
            {
                return null;
            }

            List<TDependencyObject> result = new List<TDependencyObject>();
            foreach (object @object in childrens)
            {
                if (!(@object is DependencyObject))
                {
                    continue;
                }

                if (@object is TDependencyObject)
                {
                    result.Add((TDependencyObject)@object);
                }

                if (!includeNested)
                {
                    continue;
                }

                List<TDependencyObject>? dependencyObjects_Nested = DependencyObjects<TDependencyObject>((DependencyObject)@object);
                if (dependencyObjects_Nested == null)
                {
                    continue;
                }

                foreach (TDependencyObject dependencyObject_Nested in dependencyObjects_Nested)
                {
                    result.Add(dependencyObject_Nested);
                }
            }

            return result;
        }
    }
}
