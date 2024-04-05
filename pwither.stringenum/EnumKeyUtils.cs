using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwither.enumkey
{
    public static class EnumKeyUtils
    {
        private static T GetAttributeOfType<T>(this Enum enumeration) where T : Attribute
        {
            var type = enumeration.GetType();
            var memberInfo = type.GetMember(enumeration.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        public static string GetKey(this Enum enumeration)
        {
            var attr = enumeration.GetAttributeOfType<EnumKeyAttribute>();
            if (attr is null) return null;
            if(string.IsNullOrEmpty(attr.Key)) return enumeration.ToString();
            return attr.Key;
        }
    }
}
