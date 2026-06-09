using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        /// <summary>
        /// Writes the translation model to a tab-delimited file at the specified path.
        /// </summary>
        /// <param name="translationModel">The translation model to be written.</param>
        /// <param name="path">The destination file path.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(this TranslationModel translationModel, string path)
        {
            Table? table = translationModel?.ToDiGi_Table();
            if (table == null)
            {
                return false;
            }

            return Core.IO.DelimitedData.Modify.Write(table, path, Core.IO.DelimitedData.Enums.DelimitedDataSeparator.Tab);
        }
    }
}