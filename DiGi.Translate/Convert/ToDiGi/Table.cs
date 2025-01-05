using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;
using System.Collections.Generic;

namespace DiGi.Translate
{
    public static partial class Convert
    {
        public static Table ToDiGi_Table(this TranslationModel translationModel)
        {
            if (translationModel == null)
            {
                return null;
            }

            Table result = new Table();

            HashSet<Language> languages = translationModel.GetLanguages();
            if (languages != null)
            {
                HashSet<Category> categories = translationModel.Categories;
                if (categories != null)
                {
                    foreach (Category category in categories)
                    {
                        HashSet<string> ids = translationModel.GetIds(category);
                        if (ids == null)
                        {
                            continue;
                        }

                        foreach (string id in ids)
                        {
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            dictionary.Add(Constans.ColumnName.Category, category.ToString());
                            dictionary.Add(Constans.ColumnName.Id, id);

                            foreach(Language language in languages)
                            {
                                if(!translationModel.TryGetText(category, id, language, out string text) || text == null)
                                {
                                    text = string.Empty;
                                }

                                dictionary[language.ToString()] = text;
                            }

                            result.AddRow(dictionary);
                        }
                    }
                }
            }

            return result;
        }
    }
}

