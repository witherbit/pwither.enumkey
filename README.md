## Использование (Usage):
```csharp
using pwither.enumkey;

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

Console.WriteLine($"{TestEnum.One.GetKey()} {TestEnum.Two.GetKey()} {TestEnum.Three.GetKey()} {TestEnum.Four.GetKey()}"); //return "one, two, three" because "Four" does not have the EnumKey attribute, so Four.GetKey return null
```
