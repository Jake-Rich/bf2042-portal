using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    internal class BlocklyExporter
    {
        public List<RuleBlock> Rules { get; } = new List<RuleBlock>();

        public void Import( CodeData data )
        {
            Rules.Clear();

            foreach( var action in data.Actions )
            {

            }
        }
    }

    internal class CodeData
    {
        public List<ActionBlock> Actions { get; } = new List<ActionBlock>();
    }

    internal class CodeRecorder
    {
        internal static CodeRecorder Instance { get; } = new CodeRecorder();

        private static CodeData _data = new CodeData();

        public static void AddAction( ActionBlockType action, params CommonValue[] values )
        {
            _data.Actions.Add( new ActionBlock( action, values ) );
        }
    }
}
