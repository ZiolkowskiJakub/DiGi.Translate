﻿using DiGi.Translate.Classes;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

namespace DiGi.Translate.Framework
{
    public static partial class Modify
    {
        public static bool Add(this TranslationModel translationModel, Language language, Control control, bool includeNullOrEmpty = false, bool includeNested = true)
        {
            if (translationModel == null || language == null || control == null)
            {
                return false;
            }

            string id = control.Id();
            if (id != null)
            {
                string text = control.Text;
                if (!(!includeNullOrEmpty && string.IsNullOrEmpty(text)))
                {
                    translationModel.Add(Enums.Category.Control, id, language, text);
                }
            }

            if (includeNested)
            {
                Dictionary<string, string> dictionary = Query.TextDictionary<Control>(control);
                if (dictionary != null)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in dictionary)
                    {
                        if (!includeNullOrEmpty && string.IsNullOrEmpty(keyValuePair.Value))
                        {
                            continue;
                        }

                        translationModel.Add(Enums.Category.Control, keyValuePair.Key, language, keyValuePair.Value);
                    }
                }

                if(control is DataGridView)
                {
                    dictionary = Query.TextDictionary((DataGridView)control);
                    if(dictionary != null)
                    {
                        foreach (KeyValuePair<string, string> keyValuePair in dictionary)
                        {
                            if (!includeNullOrEmpty && string.IsNullOrEmpty(keyValuePair.Value))
                            {
                                continue;
                            }

                            translationModel.Add(Enums.Category.Control, keyValuePair.Key, language, keyValuePair.Value);
                        }
                    }
                }
            }

            return true;
        }
    }
}
