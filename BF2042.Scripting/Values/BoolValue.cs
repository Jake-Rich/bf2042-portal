namespace BF2042.Scripting
{
    public class BoolValue : CommonValue
    {
        internal BoolValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {
        }

        public BoolValue( bool state ) : this( PortalInstruction.Literal_Bool, new UserValue( state.ToString() ) )
        {

        }

        public static implicit operator BoolValue( bool state )
        {
            return new BoolValue( state );
        }

        public ActionValue IfTrue( ActionValue callback )
        {
            return new IfTrue( this ) { callback };
        }

        public ActionValue IfFalse( ActionValue callback )
        {
            return new IfFalse( this ) { callback };
        }

        public BoolValue Invert()
        {
            return new BoolValue( PortalInstruction.Not, this );
        }
    }
}