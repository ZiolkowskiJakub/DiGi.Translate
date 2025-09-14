using DiGi.Core;
using DiGi.Core.Enums;
using System.Windows;


namespace DiGi.Translate.WPF
{
    public static partial class Query
    {
        public static List<T>? Controls<T>(this Form? form) where T : Control
        {
            List<Control>? controls = Controls(form);
            if (controls == null)
            {
                return null;
            }

            return [.. controls.FindAll(x => x is T).Cast<T>()];
        }

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
