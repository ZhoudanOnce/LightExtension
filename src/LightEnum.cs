using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace LightExtension
{
    public static class LightEnum
    {
        public static string GetEnumDescription<T>(this T type)
        {
            var targetType = Nullable.GetUnderlyingType(typeof(T));
            if (targetType == null)
            {
                targetType = typeof(T);
            }

            var field = targetType.GetFields().FirstOrDefault(x => x.Name == type.ToString());
            if (field == null)
            {
                return type.ToString();
            }

            var attr = field.GetCustomAttributes().FirstOrDefault(t => t.GetType() == typeof(DescriptionAttribute));
            if (attr == null)
            {
                return type.ToString();
            }

            return (attr as DescriptionAttribute)?.Description;
        }
    }
}
