using System.Collections.Generic;
using System.Linq;

namespace BF2042.Scripting
{
    internal class ActionBlock
    {
        public ActionBlock( ActionBlockType type, IEnumerable<CommonValue> values )
        {
            BlockType = type;
            Parameters = values.ToArray();
        }

        public ActionBlockType BlockType { get; }
        public CommonValue[] Parameters { get; }
    }
}
