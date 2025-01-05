using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;
using System.Collections.Generic;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        public static bool Read(this TranslationModel translationModel, string path)
        {
            if(translationModel == null)
            {
                return false;
            }

            Table table = new Table();

            if(!Core.IO.DelimitedData.Modify.Read(table, path, Core.IO.DelimitedData.Enums.DelimitedDataSeparator.Tab))
            {
                return false;
            }

            int index_Category = table.GetColumnIndex(Constans.ColumnName.Category);
            if(index_Category == -1)
            {
                return false;
            }

            int index_Id = table.GetColumnIndex(Constans.ColumnName.Id);
            if (index_Id == -1)
            {
                return false;
            }

            Dictionary<int, Language> dictionary = new Dictionary<int, Language>();
            for (int i = 0; i < table.ColumnCount; i++)
            {
                if(i == index_Category || i == index_Id)
                {
                    continue;
                }

                string languageName = table.GetColumn(i)?.Name;
                if(string.IsNullOrWhiteSpace(languageName))
                {
                    continue;
                }

                dictionary[i] = languageName;
            }

            if(dictionary.Count == 0)
            {
                return false;
            }

            bool result = false;

            foreach (Row row in table.Rows)
            {
                string value = null;

                value = row[index_Category]?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                Category category = value;

                value = row[index_Id]?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                string id = value;

                foreach(KeyValuePair<int, Language> keyValuePair in dictionary)
                {
                    bool added = translationModel.Add(category, id, keyValuePair.Value, row[keyValuePair.Key]?.ToString());
                    if(added)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}

