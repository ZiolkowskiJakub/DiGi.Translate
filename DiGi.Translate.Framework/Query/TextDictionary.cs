using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts a dictionary of text mappings from the specified control for all child controls of type <typeparamref name="TControl"/>.
        /// </summary>
        /// <typeparam name="TControl">The type of control to be retrieved.</typeparam>
        /// <param name="control">The root control to search.</param>
        /// <returns>A dictionary containing the text mappings, or null if the specified control is null or no matching controls are found.</returns>
        public static Dictionary<string, string> TextDictionary<TControl>(this Control control) where TControl : Control
        {
            if (control == null)
            {
                return null;
            }

            Dictionary<string, string> result = new Dictionary<string, string>();

            List<TControl> controls = Controls<TControl>(control);
            if (controls == null)
            {
                return null;
            }

            foreach (TControl control_Temp in controls)
            {
                string id = control_Temp?.Id();
                if (id == null)
                {
                    continue;
                }

                result[id] = control_Temp?.Text;

                if (control_Temp is DataGridView)
                {
                    Dictionary<string, string> dictionary = TextDictionary((DataGridView)(object)control_Temp);
                    if (dictionary != null)
                    {
                        foreach (KeyValuePair<string, string> keyValuePair in dictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts a dictionary of text mappings from the columns of the specified <see cref="DataGridView"/>.
        /// </summary>
        /// <param name="dataGridView">The <see cref="DataGridView"/> instance to process.</param>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> containing column identifiers and their associated values, or <c>null</c> if the columns collection is unavailable.</returns>
        public static Dictionary<string, string> TextDictionary(this DataGridView dataGridView)
        {
            DataGridViewColumnCollection dataGridViewColumnCollection = dataGridView?.Columns;

            if (dataGridViewColumnCollection == null)
            {
                return null;
            }

            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridViewColumnCollection)
            {
                string id = dataGridViewColumn.Id();
                if (string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                result[id] = dataGridViewColumn.HeaderText;
            }

            return result;
        }
    }
}