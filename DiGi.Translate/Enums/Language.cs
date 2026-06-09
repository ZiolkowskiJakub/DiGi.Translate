using System.ComponentModel;

namespace DiGi.Translate.Enums
{
    /// <summary>
    /// Defines the supported languages.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// Undefined
        /// </summary>
        [Description("Undefined")] Undefined,
        /// <summary>
        /// Polish
        /// </summary>
        [Description("Polish")] Polish,
        /// <summary>
        /// English
        /// </summary>
        [Description("English")] English,
        /// <summary>
        /// German
        /// </summary>
        [Description("German")] German,
        /// <summary>
        /// Other
        /// </summary>
        [Description("Other")] Other
    }
}