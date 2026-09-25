using System;
using System.ComponentModel;
using System.Reflection;

namespace ClassLibrary.Exceptions
{
    public static class EnumExceptionExtensions
    {
        public static string? GetDescription(this Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());
            DescriptionAttribute? attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute != null ? attribute.Description : value.ToString();
        }
    }
}