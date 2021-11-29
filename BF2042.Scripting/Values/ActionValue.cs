using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BF2042.Scripting
{
    public class ActionValue
    {
        private List<CommonValue> _parameters = new List<CommonValue>();

        internal ActionBlockType ActionType;

        internal ActionValue( ActionBlockType type, params CommonValue[] parameters )
        {
            ActionType = type;
            _parameters.AddRange( parameters );
        }

        internal ActionValue()
        {

        }

        internal IEnumerable<CommonValue> GetParameters()
        {
            return _parameters;
        }

        internal IEnumerable<T> GetParametersOfType<T>() where T : CommonValue
        {
            return _parameters.OfType<T>();
        }

        internal void Serialize( XmlWriter writer )
        {

        }
    }
}
