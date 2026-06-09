using DiGi.Core.Enums;

namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of all controls of a specified type contained within the given form.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Control"/> to retrieve.</typeparam>
        /// <param name="form">The form whose controls are to be retrieved.</param>
        /// <returns>A list of controls of type <typeparamref name="T"/> if the form and its controls collection exist; otherwise, null.</returns>
        public static List<T>? Controls<T>(this Form? form) where T : Control
        {
            List<Control>? controls = Controls(form);
            if (controls == null)
            {
                return null;
            }

            return [.. controls.FindAll(x => x is T).Cast<T>()];
        }

        /// <summary>
        /// Retrieves a list of all controls contained within the specified form.
        /// </summary>
        /// <param name="form">The form whose controls are to be retrieved.</param>
        /// <returns>A list of <see cref="Control"/> objects if the form and its controls collection exist; otherwise, null.</returns>
        public static List<Control>? Controls(this Form? form)
        {
            Control.ControlCollection? controls = form?.Controls;
            if (controls == null)
            {
                return null;
            }

            List<Control> result = [];
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
        /// Retrieves the collection of child controls for the specified control.
        /// </summary>
        /// <typeparam name="T">The type of the controls to be returned.</typeparam>
        /// <param name="control">The control whose children are being retrieved.</param>
        /// <returns>A list containing the child controls of type <typeparamref name="T"/>, or null if the collection is unavailable.</returns>
        public static List<T>? Controls<T>(this Control? control) where T : Control
        {
            Control.ControlCollection? controls = control?.Controls;
            if (controls == null)
            {
                return null;
            }

            List<Control> result = [];
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
        /// Finds all controls of a specified type that match the provided text criteria within the control hierarchy.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Control"/> to search for.</typeparam>
        /// <param name="control">The root control to begin the search from.</param>
        /// <param name="text">The text value used for comparison.</param>
        /// <param name="textComparisonType">The method used to compare the text strings.</param>
        /// <param name="caseSensitive">A value indicating whether the comparison should be case-sensitive.</param>
        /// <returns>A list of controls of type <typeparamref name="T"/> that match the criteria, or <c>null</c> if the root control is null.</returns>
        public static List<T>? Controls<T>(this Control? control, string? text, TextComparisonType textComparisonType, bool caseSensitive = true) where T : Control
        {
            if (control == null)
            {
                return null;
            }

            List<T> controls = [];
            Controls(control, ref controls);

            List<T> result = [];
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

        private static void Controls<T>(Control? control, ref List<T> controls) where T : Control
        {
            controls ??= [];

            Control.ControlCollection? controls_Temp = control?.Controls;
            if (controls_Temp == null || controls_Temp.Count == 0)
            {
                return;
            }

            foreach (Control control_Temp in controls_Temp)
            {
                Controls(control_Temp, ref controls);

                if (control_Temp is not T t)
                {
                    continue;
                }

                controls.Add(t);
            }
        }
    }
}