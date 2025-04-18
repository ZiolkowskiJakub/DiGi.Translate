﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Query
    {
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

                if(control_Temp is DataGridView)
                {
                    Dictionary<string, string> dictionary = TextDictionary((DataGridView)(object)control_Temp);
                    if(dictionary != null)
                    {
                        foreach(KeyValuePair<string, string> keyValuePair in dictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        public static Dictionary<string, string> TextDictionary(this DataGridView dataGridView)
        {
            DataGridViewColumnCollection dataGridViewColumnCollection = dataGridView?.Columns;

            if(dataGridViewColumnCollection == null)
            {
                return null;
            }

            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridViewColumnCollection)
            {
                string id = dataGridViewColumn.Id();
                if(string.IsNullOrWhiteSpace(id))
                {
                    continue;
                }

                result[id] = dataGridViewColumn.HeaderText;

            }

            return result;
        }
    }
}