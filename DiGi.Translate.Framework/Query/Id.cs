using System.Windows.Forms;

namespace DiGi.Translate.Framework
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
            if (string.IsNullOrWhiteSpace(result))
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
    }
}
