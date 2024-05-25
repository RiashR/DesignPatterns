using System.ComponentModel;

namespace InsuranceQuoteGenerator.Enums
{
    public enum InsuranceType
    {
        [Description("Car Insurance")]
        Car,

        [Description("Home Insurance")]
        Home
    }

    public static class EnumExtensions
    {
        public static string GetDescriptiion(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            return descriptionAttribute != null ? descriptionAttribute.Description : value.ToString();
        }
    }
}
