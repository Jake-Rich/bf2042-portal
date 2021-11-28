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
    }
}