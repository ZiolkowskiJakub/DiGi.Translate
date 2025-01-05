using DiGi.Core.IO.Table.Classes;
using DiGi.Translate.Classes;

namespace DiGi.Translate
{
    public static partial class Modify
    {
        public static bool Write(this TranslationModel translationModel, string path)
        {
            Table table = translationModel?.ToDiGi_Table();
            if(table == null)
            {
                return false;
            }

            return Core.IO.DelimitedData.Modify.Write(table, path, Core.IO.DelimitedData.Enums.DelimitedDataSeparator.Tab);
        }
    }
}

