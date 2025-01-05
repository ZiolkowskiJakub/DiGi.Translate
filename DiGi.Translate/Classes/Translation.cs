using System;
using System.Collections.Generic;

namespace DiGi.Translate.Classes
{
    public class Translation
    {
        private Category category;
        private string id;
        private Dictionary<Language, string> dictionary = new Dictionary<Language, string>();

        public Translation(Category category, string id)
        {
            this.category = category == null ? null : new Category(category);
            this.id = id;
        }

        public bool Add(Language language, string text)
        {
            if (language == null)
            {
                return false;
            }

            dictionary[language] = text;
            return true;
        }

        public bool TryGetText(Language language, out string text)
        {
            if (language == null || !dictionary.TryGetValue(language, out text))
            {
                text = null;
                return false;
            }

            return true;
        }

        public string this[Language language]
        {
            get
            {
                if (!TryGetText(language, out string result))
                {
                    result = null;
                }

                return result;
            }
        }

        public Category Category
        {
            get
            {
                return category;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public HashSet<Language> Languages
        {
            get
            {
                return new HashSet<Language>(dictionary?.Keys);
            }
        }
    }
}
