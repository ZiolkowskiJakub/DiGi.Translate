using System.Collections.Generic;
using System.Windows;

namespace DiGi.Translate.Framework
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of child dependency objects from the specified dependency object.
        /// </summary>
        /// <typeparam name="TDependencyObject">The type of dependency objects to retrieve.</typeparam>
        /// <param name="dependencyObject">The source dependency object to query.</param>
        /// <param name="includeNested">Indicates whether to recursively include nested child dependency objects.</param>
        /// <returns>A list of found dependency objects of type <typeparamref name="TDependencyObject"/>, or null if no children are present.</returns>
        public static List<TDependencyObject> DependencyObjects<TDependencyObject>(this DependencyObject dependencyObject, bool includeNested = true) where TDependencyObject : DependencyObject
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

                List<TDependencyObject> dependencyObjects_Nested = DependencyObjects<TDependencyObject>((DependencyObject)@object);
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