using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BF2042.Scripting
{
    public class CommonValue
    {
        internal PortalInstruction Instruction { get; private set; }
        internal IReadOnlyCollection<CommonValue> Parameters { get; private set; }

        internal CommonValue( PortalInstruction instruction, params CommonValue[] values )
        {
            SetInstructions( instruction, values );
        }

        internal CommonValue()
        {

        }

        internal static T Factory<T>() where T : CommonValue
        {
            return Activator.CreateInstance( type: typeof( T ), bindingAttr: BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, null, null ) as T;
        }

        public static implicit operator CommonValue( double value )
        {
            return new NumberValue( value );
        }

        public static implicit operator CommonValue( bool state )
        {
            return new BoolValue( state );
        }

        internal void SetInstructions( PortalInstruction instruction, params CommonValue[] values )
        {
            Instruction = instruction;
            Parameters = values.ToArray();
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
}