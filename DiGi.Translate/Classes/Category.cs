
namespace DiGi.Translate.Classes
{
    public class Category
    {
        public string Name { get; }

        public Category(string name)
        {
            Name = name == null ? string.Empty : name;
        }

        public Category(Category category)
        {
            Name = category?.Name == null ? string.Empty : category.Name;
        }

        public Category(Enums.Category category)
        {
            Name = category.ToString();
        }

        public override string ToString() 
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public static implicit operator Category(string name)
        {
            return new Category(name);
        }

        public static implicit operator Category(Enums.Category category)
        {
            return new Category(category);
        }

        public static bool operator ==(Category category_1, Category category_2)
        {
            if (Equals(category_1, category_2))
            {
                return true;
            }

            if (Equals(category_1, null))
            {
                return false;
            }

            if (Equals(category_2, null))
            {
                return false;
            }

            return category_1.Name == category_2.Name;
        }

        public static bool operator !=(Category category_1, Category category_2)
        {
            return category_1?.Name != category_2?.Name;
        }
    }
}
