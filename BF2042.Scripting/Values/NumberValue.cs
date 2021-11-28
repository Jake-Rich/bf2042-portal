using System;

namespace BF2042.Scripting
{
    public class NumberValue : CommonValue
    {
        internal NumberValue( PortalInstruction instruction, params CommonValue[] values ) : base( instruction, values )
        {

        }

        public NumberValue( double number ) : this( PortalInstruction.Literal_Number, new UserValue( number.ToString() ) )
        {
            
        }

        public NumberValue Abs()
        {
            return new NumberValue( PortalInstruction.AbsNumber, this );
        }

        public NumberValue Add( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Add_Number, this, value2 );
        }

        public NumberValue Subtract( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Subtract_Number, this, value2 );
        }

        public NumberValue Multiply( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Multiply_Number, this, value2 );
        }

        public NumberValue Divide( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Divide_Number, this, value2 );
        }

        public NumberValue AngleDifference( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.AngleDifference, this, value2 );
        }

        public NumberValue Cosine_Degrees()
        {
            return new NumberValue( PortalInstruction.CosineFromDegrees, this );
        }

        public NumberValue Cosine_Radians()
        {
            return new NumberValue( PortalInstruction.CosineFromRadians, this );
        }

        public NumberValue Sine_Degrees()
        {
            return new NumberValue( PortalInstruction.SineFromDegrees, this );
        }

        public NumberValue Sine_Radians()
        {
            return new NumberValue( PortalInstruction.SineFromRadians, this );
        }

        public NumberValue Min( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Min, this, value2 );
        }

        public NumberValue Max( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Max, this, value2 );
        }

        public NumberValue Modulo( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.Modulo, this, value2 );
        }

        public NumberValue Pow( NumberValue value2 )
        {
            return new NumberValue( PortalInstruction.RaiseToPower, this, value2 );
        }

        public NumberValue Random( NumberValue max )
        {
            return new NumberValue( PortalInstruction.RandomReal, this, max );
        }

        public NumberValue RoundToInt()
        {
            return new NumberValue( PortalInstruction.RoundToInteger, this );
        }

        public NumberValue Sqrt()
        {
            return new NumberValue( PortalInstruction.SquareRoot, this );
        }

        public BoolValue IsGreater( NumberValue other )
        {
            return new BoolValue( PortalInstruction.GreaterThan, this, other );
        }

        public BoolValue IsGreaterOrEqual( NumberValue other )
        {
            return new BoolValue( PortalInstruction.GreaterThanEqualTo, this, other );
        }

        public BoolValue IsLess( NumberValue other )
        {
            return new BoolValue( PortalInstruction.LessThan, this, other );
        }

        public BoolValue IsLessOrEqual( NumberValue other )
        {
            return new BoolValue( PortalInstruction.LessThanEqualTo, this, other );
        }
    }
}