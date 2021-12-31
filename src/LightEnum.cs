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
            // 判断是否为可控类型
            var targetType = Nullable.GetUnderlyingType(typeof(T));
            if (targetType == null)
            {
                targetType = typeof(T);
            }

            var fields = targetType.GetFields();
            var field = Array.Find(fields, p => p.Name == type.ToString());
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
