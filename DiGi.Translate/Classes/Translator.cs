namespace DiGi.Translate.Classes
{
    public class Translator
    {
        private TranslationModel translationModel;
        public Language Language { get; set; }

        public Translator(TranslationModel translationModel, Language language)
        {
            this.translationModel = translationModel;
            Language = language;
        }

        public bool TryGetText(Category category, string id, out string text)
        {
            text = null;
            if(category == null || id == null)
            {
                return false;
            }

            return translationModel.TryGetText(category, id, Language, out text);
        }

        public bool TryGetText(string category, string id, out string text)
        {
            text = null;
            if(category == null || id == null)
            {
                return false;
            }

            return TryGetText(new Category(category), id, out text);
        }
    }
}
