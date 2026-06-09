using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;
using System.Collections.Generic;

namespace DiGi.Translate
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="TranslationModel"/> instance into a <see cref="Table"/> representation.
        /// </summary>
        /// <param name="translationModel">The translation model to convert.</param>
        /// <returns>A <see cref="Table"/> object containing the translated data, or <see langword="null"/> if the <paramref name="translationModel"/> is null.</returns>
        public static Table? ToDiGi_Table(this TranslationModel? translationModel)
        {
            if (translationModel == null)
            {
                return null;
            }

            Table result = new();

            HashSet<Language> languages = translationModel.GetLanguages();
            if (languages != null)
            {
                HashSet<Category> categories = translationModel.Categories;
                if (categories != null)
                {
                    foreach (Category category in categories)
                    {
                        HashSet<string>? ids = translationModel.GetIds(category);
                        if (ids == null)
                        {
                            continue;
                        }

                        foreach (string id in ids)
                        {
                            Dictionary<string, object> dictionary = new()
                            {
                                { Constants.ColumnName.Category, category.ToString() },
                                { Constants.ColumnName.Id, id }
                            };

                            foreach (Language language in languages)
                            {
                                if (!translationModel.TryGetText(category, id, language, out string? text) || text == null)
                                {
                                    text = string.Empty;
                                }

                                text = text.Replace("\n", "\\n");

                                dictionary[language.ToString()] = text;
                            }

                            result.AddRow(dictionary!);
                        }
                    }
                }
            }

            return result;
        }
    }
}