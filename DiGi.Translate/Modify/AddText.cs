using DiGi.Translate.Classes;
using System;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        public static bool AddText(this TranslationModel? translationModel, Language? language, string? text, Func<string?, string?>? func = null)
        {
            if (translationModel is null || language is null)
            {
                return false;
            }

            func ??= x => x;

            return translationModel.Add(new Category(Enums.Category.Text), func.Invoke(text), language, text);
        }
    }
}