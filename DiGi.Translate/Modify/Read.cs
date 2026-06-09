using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;
using System.Collections.Generic;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        /// <summary>
        /// Reads translation data from a specified tab-delimited file and populates the provided translation model.
        /// </summary>
        /// <param name="translationModel">The translation model to be populated with the read data.</param>
        /// <param name="path">The path to the source file containing the translation data.</param>
        /// <returns><c>true</c> if the data was successfully read and loaded into the model; otherwise, <c>false</c>.</returns>
        public static bool Read(this TranslationModel? translationModel, string? path)
        {
            if (translationModel == null)
            {
                return false;
            }

            Table table = new();

            if (!Core.IO.DelimitedData.Modify.Read(table, path, Core.IO.DelimitedData.Enums.DelimitedDataSeparator.Tab))
            {
                return false;
            }

            int index_Category = table.GetColumnIndex(Constants.ColumnName.Category);
            if (index_Category == -1)
            {
                return false;
            }

            int index_Id = table.GetColumnIndex(Constants.ColumnName.Id);
            if (index_Id == -1)
            {
                return false;
            }

            Dictionary<int, Language> dictionary = [];
            for (int i = 0; i < table.ColumnCount; i++)
            {
                if (i == index_Category || i == index_Id)
                {
                    continue;
                }

                string? languageName = table.GetColumn(i)?.Name;
                if (string.IsNullOrWhiteSpace(languageName))
                {
                    continue;
                }

                dictionary[i] = languageName!;
            }

            if (dictionary.Count == 0)
            {
                return false;
            }

            bool result = false;

            foreach (Row row in table.Rows)
            {
                string? value = null;

                value = row[index_Category]?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                Category? category = value!;

                value = row[index_Id]?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                string? id = value;

                foreach (KeyValuePair<int, Language> keyValuePair in dictionary)
                {
                    string? text = row[keyValuePair.Key]?.ToString();
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        text = text?.Replace("\\n", "\n");
                    }

                    bool added = translationModel.Add(category, id, keyValuePair.Value, text);
                    if (added)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}