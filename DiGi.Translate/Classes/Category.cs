namespace DiGi.Translate.Classes
{
    /// <summary>
    /// Represents a category used for classification.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets the name of the category.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class with a specified name.
        /// </summary>
        /// <param name="name">The name of the category.</param>
        public Category(string name)
        {
            Name = name == null ? string.Empty : name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class using another <see cref="Category"/> object.
        /// </summary>
        /// <param name="category">The source category to copy from.</param>
        public Category(Category category)
        {
            Name = category?.Name == null ? string.Empty : category.Name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class using a specified category enumeration value.
        /// </summary>
        /// <param name="category">The category enumeration value used to initialize the category name.</param>
        public Category(Enums.Category category)
        {
            Name = category.ToString();
        }

        /// <summary>
        /// Returns a string representation of the category.
        /// </summary>
        /// <returns>The name of the category.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current category based on their string representations.
        /// </summary>
        /// <param name="obj">The object to compare with the current category.</param>
        /// <returns><see langword="true"/> if the objects are considered equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        /// <summary>
        /// Returns a hash code for the current category based on its name.
        /// </summary>
        /// <returns>A numeric hash code.</returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        /// <summary>
        /// Implicitly converts a string to a <see cref="Category"/> instance.
        /// </summary>
        /// <param name="name">The name of the category to convert.</param>
        /// <returns>A new <see cref="Category"/> instance created from the specified name.</returns>
        public static implicit operator Category(string name)
        {
            return new Category(name);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Enums.Category"/> enumeration value to a <see cref="Category"/> instance.
        /// </summary>
        /// <param name="category">The category enumeration value to convert.</param>
        /// <returns>A new <see cref="Category"/> instance created from the specified enumeration value.</returns>
        public static implicit operator Category(Enums.Category category)
        {
            return new Category(category);
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Category"/> objects are equal.
        /// </summary>
        /// <param name="category_1">The first category to compare.</param>
        /// <param name="category_2">The second category to compare.</param>
        /// <returns><see langword="true"/> if the categories are equal; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Indicates whether two <see cref="Category"/> instances are not equal based on their names.
        /// </summary>
        /// <param name="category_1">The first <see cref="Category"/> to compare.</param>
        /// <param name="category_2">The second <see cref="Category"/> to compare.</param>
        /// <returns><see langword="true"/> if the categories are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Category category_1, Category category_2)
        {
            return category_1?.Name != category_2?.Name;
        }
    }
}