using System;

namespace BF2042.Scripting
{
    public class UniversalValue : CommonValue
    {
        public static implicit operator NumberValue( UniversalValue value )
        {
            throw new NotImplementedException();
        }
    }
}