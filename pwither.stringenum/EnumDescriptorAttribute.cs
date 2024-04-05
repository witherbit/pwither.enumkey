using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwither.enumkey
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class EnumKeyAttribute : Attribute
    {
        public string Key { get; private set; }

        public EnumKeyAttribute(string key)
        {
            Key = key;
        }
        public EnumKeyAttribute()
        {
        }
    }
}
