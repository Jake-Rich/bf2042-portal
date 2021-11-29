using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    public class ActionAttribute : Attribute
    {
    }

    public class NameAttribute : Attribute
    {
        public NameAttribute( string name )
        {

        }
    }

    public class EnumSelectionAttribute : Attribute
    {
        public EnumSelectionAttribute( string blockId, string field1 )
        {

        }
    }
}
