using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Query
    {
        public static bool TryGetControl(this Control control, string id, out Control result)
        {
            result = null;

            if (control == null || string.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            List<Control> controls = Controls<Control>(control);
            if (controls == null)
            {
                return false;
            }

            List<Tuple<string, Control>> tuples = new List<Tuple<string, Control>>();
            foreach (Control control_Temp in controls)
            {
                string id_Control = control_Temp.Id();
                if (id.Equals(id_Control))
                {
                    result = control_Temp;
                    return true;
                }
                tuples.Add(new Tuple<string, Control>(id_Control, control_Temp));
            }

            if (tuples != null)
            {
                foreach (Tuple<string, Control> tuple in tuples)
                {
                    if (tuple.Item1.EndsWith(id))
                    {
                        result = tuple.Item2;
                        return true;
                    }
                }


                List<string> values = id.Split('.')?.ToList();
                if (values.Count > 1)
                {
                    string start = values[0];
                    values.RemoveAt(0);
                    string end = string.Join(".", values);
                    foreach (Tuple<string, Control> tuple in tuples)
                    {
                        string id_Temp = tuple.Item1;

                        if (id_Temp.StartsWith(start) && id_Temp.EndsWith(end))
                        {
                            result = tuple.Item2;
                            return true;
                        }
                    }
                }

            }

            return false;
        }
    }
}
