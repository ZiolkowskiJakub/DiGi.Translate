using System.ComponentModel;

namespace DiGi.Translate.Enums
{
    /// <summary>
    /// Defines the categories used to classify translation content.
    /// </summary>
    public enum Category
    {
        /// <summary>
        /// Represents an undefined category for translation content.
        /// </summary>
        [Description("Undefined")] Undefined,
        /// <summary>
        /// Represents a category for control-based translation content.
        /// </summary>
        [Description("Control")] Control,
        /// <summary>
        /// Represents a category for message-based translation content.
        /// </summary>
        [Description("Message")] Message,
        /// <summary>
        /// Defines the categories used to classify translation content.
        /// </summary>
        [Description("Enumerator")] Enum,
        /// <summary>
        /// Represents a category for general text content.
        /// </summary>
        [Description("Text")] Text,
        /// <summary>
        /// Represents a miscellaneous or unspecified category.
        /// </summary>
        [Description("Other")] Other
    }
}