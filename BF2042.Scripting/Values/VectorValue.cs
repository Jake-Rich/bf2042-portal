namespace BF2042.Scripting
{
    public class VectorValue : CommonValue
    {
        public static VectorValue Up { get { return new VectorValue( PortalInstruction.UpVector ); } }
        public static VectorValue Down { get { return new VectorValue( PortalInstruction.DownVector ); } }
        public static VectorValue Left { get { return new VectorValue( PortalInstruction.LeftVector ); } }
        public static VectorValue Right { get { return new VectorValue( PortalInstruction.RightVector ); } }
        public static VectorValue Forward { get { return new VectorValue( PortalInstruction.ForwardVector ); } }
        public static VectorValue Backwards { get { return new VectorValue( PortalInstruction.BackwardsVector ); } }

        internal VectorValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {

        }

        public VectorValue( NumberValue x, NumberValue y, NumberValue z ) : this( PortalInstruction.CreateVector, x, y, z )
        {

        }

        public VectorValue( double x, double y, double z ) : this( new NumberValue( x ), new NumberValue( y ), new NumberValue ( z ) )
        {

        }

        public NumberValue GetX()
        {
            return new NumberValue( PortalInstruction.Vector_GetX, this );
        }

        public NumberValue GetY()
        {
            return new NumberValue( PortalInstruction.Vector_GetY, this );
        }

        public NumberValue GetZ()
        {
            return new NumberValue( PortalInstruction.Vector_GetZ, this );
        }

        public VectorValue Normalize()
        {
            return new VectorValue( PortalInstruction.Normalize, this );
        }

        public PlayerValue GetClosestPlayer( TeamValue team = null )
        {
            return new PlayerValue( PortalInstruction.ClosestPlayerTo, this, team );
        }

        public PlayerValue GetFurthestPlayer( TeamValue team = null )
        {
            return new PlayerValue( PortalInstruction.FarthestPlayerFrom, this, team );
        }
    }
}