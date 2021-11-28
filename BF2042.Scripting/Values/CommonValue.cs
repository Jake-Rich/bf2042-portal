using System;
using System.Collections.Generic;

namespace BF2042.Scripting
{
    public class CommonValue
    {
        internal CodeRecorder _recorder;

        public CommonValue( PortalInstruction instruction, params CommonValue[] values )
        {
            SetInstructions( instruction, values );
        }

        public CommonValue()
        {

        }

        internal void SetInstructions( PortalInstruction instruction, params CommonValue[] values )
        {

        }

        public BoolValue IsEqual( CommonValue other )
        {
            return new BoolValue( PortalInstruction.Equals, this, other );
        }

        public BoolValue NotEqual( CommonValue other )
        {
            return new BoolValue( PortalInstruction.NotEqualTo, this, other );
        }

        private const string _equalsError = "Use CommonValue.IsEqual() not '==', '!=' or '.Equals()'";

        public override bool Equals( object other )
        {
            throw new NotSupportedException( _equalsError );
        }

        public override int GetHashCode()
        {
            throw new NotSupportedException( _equalsError );
        }
    }

    public static class CommonValueEx
    {
        internal static T FromActionBlock<T>( this T value, RuleEventType type ) where T : CommonValue
        {
            throw new NotImplementedException();

            return value;
        }
    }
}