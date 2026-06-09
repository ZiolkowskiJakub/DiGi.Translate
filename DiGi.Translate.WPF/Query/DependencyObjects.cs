using System.Windows;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a collection of child dependency objects from the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <typeparam name="TDependencyObject">The type of dependency object to be retrieved.</typeparam>
        /// <param name="dependencyObject">The source dependency object to query for children.</param>
        /// <param name="includeNested">Indicates whether to include nested child elements in the search.</param>
        /// <returns>A list containing the found dependency objects, or <see langword="null"/> if no children are available.</returns>
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