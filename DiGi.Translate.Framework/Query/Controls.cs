using DiGi.Core.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of all controls of the specified type associated with the given form.
        /// </summary>
        /// <typeparam name="T">The type of controls to retrieve.</typeparam>
        /// <param name="form">The form whose controls are to be retrieved.</param>
        /// <returns>A list of controls of type <typeparam ref="T"/>, or null if the form is null or its control collection is unavailable.</returns>
        public static List<T> Controls<T>(this Form form) where T : Control
        {
            List<Control> controls = Controls(form);
            if (controls == null)
            {
                return null;
            }

            return controls.FindAll(x => x is T).Cast<T>().ToList();
        }

        /// <summary>
        /// Retrieves a list of all controls associated with the specified form.
        /// </summary>
        /// <param name="form">The form whose controls are to be retrieved.</param>
        /// <returns>A list of <see cref="Control"/> objects, or null if the form is null or its control collection is unavailable.</returns>
        public static List<Control> Controls(this Form form)
        {
            Control.ControlCollection controls = form?.Controls;
            if (controls == null)
            {
                return null;
            }

            List<Control> result = new List<Control>();
            foreach (Control control in controls)
            {
                if (control == null)
                {
                    continue;
                }

                result.Add(control);
                Controls(control, ref result);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of controls associated with the specified control.
        /// </summary>
        /// <typeparam name="T">The type of control to retrieve, which must derive from <see cref="Control"/>.</typeparam>
        /// <param name="control">The control whose child controls are to be retrieved.</param>
        /// <returns>A list of controls associated with the specified control, or null if the collection is unavailable.</returns>
        public static List<T> Controls<T>(this Control control) where T : Control
        {
            Control.ControlCollection controls = control?.Controls;
            if (controls == null)
            {
                return null;
            }

            List<Control> result = new List<Control>();
            foreach (Control control_Temp in controls)
            {
                if (control_Temp == null)
                {
                    continue;
                }
                result.Add(control_Temp);
                Controls(control_Temp, ref result);
            }

            return result.FindAll(x => x is T).ConvertAll(x => (T)x);
        }

        /// <summary>
        /// Retrieves a list of controls of type <typeparamref name="T"/> that match the specified text criteria within the control hierarchy.
        /// </summary>
        /// <typeparam name="T">The type of Control to be returned.</typeparam>
        /// <param name="control">The root control to search from.</param>
        /// <param name="text">The text value used for comparison.</param>
        /// <param name="textComparisonType">The method used to compare the strings.</param>
        /// <param name="caseSensitive">Indicates whether the text comparison should be case-sensitive.</param>
        /// <returns>A list of controls of type <typeparamref name="T"/> that match the criteria, or null if the source control is null.</returns>
        public static List<T> Controls<T>(this Control control, string text, TextComparisonType textComparisonType, bool caseSensitive = true) where T : Control
        {
            if (control == null)
            {
                return null;
            }

            List<T> controls = new List<T>();
            Controls(control, ref controls);

            List<T> result = new List<T>();
            if (controls == null || controls.Count == 0)
            {
                return result;
            }

            foreach (T t in controls)
            {
                if (Core.Query.Compare(t.Name, text, textComparisonType, caseSensitive))
                {
                    result.Add(t);
                }
            }

            return result;
        }

        private static void Controls<T>(Control control, ref List<T> controls) where T : Control
        {
            if (controls == null)
            {
                controls = new List<T>();
            }

            Control.ControlCollection controls_Temp = control?.Controls;
            if (controls_Temp == null || controls_Temp.Count == 0)
            {
                return;
            }

            foreach (Control control_Temp in controls_Temp)
            {
                Controls(control_Temp, ref controls);

                T t = control_Temp as T;
                if (t == null)
                {
                    continue;
                }

                controls.Add(t);
            }
        }
    }
}