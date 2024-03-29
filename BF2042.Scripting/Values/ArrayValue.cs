﻿using System;

namespace BF2042.Scripting
{
    public class ArrayValue<T> : CommonValue where T : CommonValue
    {
        internal ArrayValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {

        }

        public ArrayValue Append( T value )
        {
            return new ArrayValue( PortalInstruction.Array_Append, this, value );
        }

        public ArrayValue CopyAndSlice( NumberValue startIndex, NumberValue count )
        {
            return new ArrayValue( PortalInstruction.Array_Slice, this, startIndex, count );
        }

        public ArrayValue CopyAndFilter( Action<ArrayContext> filter )
        {
            return new ArrayValue( PortalInstruction.Array_FilteredArray, this );
        }

        public ArrayValue CopyAndSelect( Action<ArrayContext> remap )
        {
            return new ArrayValue( PortalInstruction.Array_MappedArray, this );
        }

        public ArrayValue CopyAndRemove( T toRemove )
        {
            return new ArrayValue( PortalInstruction.Array_MappedArray, this );
        }

        public BoolValue Contains( T toRemove )
        {
            return new BoolValue( PortalInstruction.Array_Contains, this, toRemove );
        }

        public NumberValue IndexOf( T toRemove )
        {
            return new NumberValue( PortalInstruction.Array_IndexOf, this, toRemove );
        }

        public ArrayValue Shuffle()
        {
            return new ArrayValue( PortalInstruction.Array_RandomizedArray, this );
        }

        public T First()
        {
            T value = CommonValue.Factory<T>();
            value.SetInstructions( PortalInstruction.Array_FirstOf, this );
            return value;
        }

        public T Last()
        {
            T value = CommonValue.Factory<T>();
            value.SetInstructions( PortalInstruction.Array_LastOf, this );
            return value;
        }

        public T RandomValue()
        {
            T value = CommonValue.Factory<T>();
            value.SetInstructions( PortalInstruction.Array_RandomizedArray, this );
            return value;
        }
    }

    public class ArrayValue : ArrayValue<CommonValue>
    {
        internal ArrayValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {
        }

        public static ArrayValue Empty { get { return new ArrayValue( PortalInstruction.Array_EmptyArray ); } }
    }
}