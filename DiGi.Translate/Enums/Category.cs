using System.ComponentModel;

namespace DiGi.Translate.Enums
{
    public enum Category
    {
        [Description("Undefined")] Undefined,
        [Description("Control")] Control,
        [Description("Message")] Message,
        [Description("Enumerator")] Enum,
        [Description("Text")] Text,
        [Description("Other")] Other
    }
}
