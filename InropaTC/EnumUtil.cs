using System.ComponentModel;
using System.Reflection;

namespace InropaTC
{
    public static class EnumUtil
    {
        public static IEnumerable<T> GetEnumValues<T>()
        {
            // Can't use type constraints on value types, so have to do check like this
            if (typeof(T).BaseType != typeof(Enum))
            {
                throw new ArgumentException("object must be of type System.Enum");
            }

            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public static string GetEnumName<T>(int enumVal)
        {
            if (typeof(T).BaseType != typeof(Enum))
            {
                throw new ArgumentException("object must be of type System.Enum");
            }
            return Enum.GetName(typeof(T), enumVal);
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}