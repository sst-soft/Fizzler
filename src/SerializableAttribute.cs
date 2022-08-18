// GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007. https://github.com/sst-soft/Fizzler which is a fork of https://github.com/atifaziz/Fizzler.

#if NETSTANDARD1_0

namespace Fizzler
{
    using Attribute = System.Attribute;
    using AttributeUsageAttribute = System.AttributeUsageAttribute;
    using static System.AttributeTargets;

    [AttributeUsage(Class | Struct | Enum | Delegate)]
    sealed class SerializableAttribute : Attribute {}
}

#endif
