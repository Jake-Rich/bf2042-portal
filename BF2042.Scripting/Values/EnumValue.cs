﻿using System;

namespace BF2042.Scripting
{
    internal class EnumValue<T> : EnumValue where T : Enum
    {
        public EnumValue( T val ) : base( typeof(T) )
        {
            
        }
    }

    internal class EnumValue : CommonValue
    {
        internal Type EnumType { get; }

        internal EnumValue( Type type )
        {
            EnumType = type;
        }

        public static EnumValue<T> Create<T>( T value ) where T : Enum
        {
            return new EnumValue<T>( value );
        }

        public static EnumValue<T> CreateNullable<T>( T? value ) where T : struct, Enum
        {
            if ( value == null )
            {
                return null;
            }

            return new EnumValue<T>( value.Value );
        }
    }

}