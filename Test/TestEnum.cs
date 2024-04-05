using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pwither.enumkey;

namespace Test
{
    internal enum TestEnum
    {
        [EnumKey("one")]
        One,
        [EnumKey("two")]
        Two,
        [EnumKey]
        Three,
        Four
    }
}
