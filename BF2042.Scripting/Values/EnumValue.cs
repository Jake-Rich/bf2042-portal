using System;

namespace BF2042.Scripting
{
    internal class EnumValue<T> : EnumValue where T : Enum
    {
        public EnumValue( T val )
        {

        }
    }

    internal class EnumValue : CommonValue
    {
        public static EnumValue<T> Create<T>( T value ) where T : Enum
        {
            return new EnumValue<T>( value );
        }
    }

}