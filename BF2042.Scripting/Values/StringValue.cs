namespace BF2042.Scripting
{
    public class StringValue : CommonValue
    {
        internal StringValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {
        }

        public StringValue( string text ) : this ( PortalInstruction.Literal_String, new UserValue( text ) )
        {

        }

        public static implicit operator StringValue( string text )
        {
            return new StringValue( text );
        }
    }
}