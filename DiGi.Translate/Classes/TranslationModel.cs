using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DiGi.Translate.Classes
{
    public class TranslationModel
    {
        private Dictionary<Category, SortedDictionary<string, Translation>> dictionary = new Dictionary<Category, SortedDictionary<string, Translation>>();

        public TranslationModel() 
        {
            
        }

        public HashSet<Language> Add(Translation translation)
        {
            Category category = translation?.Category;
            if(category == null)
            {
                return null;
            }

            string id = translation.Id;
            if(id == null)
            {
                return null;
            }

            HashSet<Language> languages = translation.Languages;
            if (languages == null)
            {
                return null;
            }

            Dictionary<Language, string> dictionary = new Dictionary<Language, string>();
            foreach (Language language in languages)
            {
                dictionary[language] = translation[language];
            }

            return Add(category, id, dictionary);
        }

        public bool Add(Category category, string id, Language language, string text)
        {
            if(category == null || id == null || language == null)
            {
                return false;
            }

            HashSet<Language> languages = Add(category, id, new KeyValuePair<Language, string>[] { new KeyValuePair<Language, string>(language, text) });
            if(languages == null || languages.Count == 0)
            {
                return false;
            }

            return languages.Contains(language);
        }

        private HashSet<Language> Add(Category category, string id, IEnumerable<KeyValuePair<Language, string>> keyValuePairs)
        {
            if (category == null || id == null || keyValuePairs == null || keyValuePairs.Count() == 0)
            {
                return null;
            }

            if (!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary == null)
            {
                sortedDictionary = new SortedDictionary<string, Translation>();
                dictionary[category] = sortedDictionary;
            }

            if (!sortedDictionary.TryGetValue(id, out Translation translation) || translation == null)
            {
                translation = new Translation(category, id);
                sortedDictionary[id] = translation;
            }

            HashSet<Language> result = new HashSet<Language>();
            foreach(KeyValuePair<Language, string> keyValuePair in keyValuePairs)
            {
                if(translation.Add(keyValuePair.Key, keyValuePair.Value))
                {
                    result.Add(keyValuePair.Key);
                }
            }

            return result;
        }

        public bool TryGetText(Category category, string id, Language language, out string text)
        {
            text = null;

            if (category == null || id == null || language == null)
            {
                return false;
            }

            if(!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary == null)
            {
                return false;
            }

            if(!sortedDictionary.TryGetValue(id, out Translation translation) || translation == null)
            {
                return false;
            }

            return translation.TryGetText(language, out text);
        }

        public bool TryGetText(string category, string id, string language, out string text)
        {
            text = null;

            if (category == null || id == null || language == null)
            {
                return false;
            }

            return TryGetText(new Category(category), id, new Language(language), out text);
        }

        public HashSet<Category> Categories
        {
            get
            {
                return new HashSet<Category>(dictionary.Keys);
            }
        }

        public HashSet<Language> GetLanguages()
        {
            HashSet<Language> result = new HashSet<Language>();
            foreach (SortedDictionary<string, Translation> sortedDictionary in dictionary.Values)
            {
                foreach(Translation translation in sortedDictionary.Values)
                {
                    HashSet<Language> languages = translation?.Languages;
                    if (languages == null)
                    {
                        continue;
                    }

                    foreach(Language language in languages)
                    {
                        result.Add(language);
                    }
                }
            }

            return result;
        }

        public HashSet<Language> GetLanguages(Category category)
        {
            if(category == null)
            {
                return null;
            }

            HashSet<Language> result = new HashSet<Language>();
            foreach (KeyValuePair<Category, SortedDictionary<string, Translation>> keyValuePair in dictionary)
            {
                if(category != keyValuePair.Key)
                {
                    continue;
                }

                foreach (Translation translation in keyValuePair.Value.Values)
                {
                    HashSet<Language> languages = translation?.Languages;
                    if (languages == null)
                    {
                        continue;
                    }

                    foreach (Language language in languages)
                    {
                        result.Add(language);
                    }
                }
            }

            return result;
        }

        public HashSet<string> GetIds(Category category)
        {
            if(category == null)
            {
                return null;
            }

            if(!dictionary.TryGetValue(category, out SortedDictionary<string, Translation> sortedDictionary) || sortedDictionary == null)
            {
                return null;
            }

            return new HashSet<string>(sortedDictionary.Keys);
        }
    }
}
