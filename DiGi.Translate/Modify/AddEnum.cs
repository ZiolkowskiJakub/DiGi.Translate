using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        public static bool AddEnum<T>(this TranslationModel translationModel, Language language, Func<T, string> func = null) where T : Enum
        {
            if(translationModel == null || language == null)
            {
                return false;
            }

            if(func == null)
            {
                func = x => Core.Query.Description(x);
            }

            bool result = false;
            foreach(T value in Enum.GetValues(typeof(T)))
            {
                string text = func.Invoke(value);

                if(translationModel.Add(value, language, text))
                {
                    result = true;
                }
            }

            return true;
        }
    }
}

