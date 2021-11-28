using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    internal class RuleBlock
    {
        public RuleBlock( RuleEventType eventType )
        {

        }

        public List<ConditionBlock> Conditions { get; } = new List<ConditionBlock>();

        public List<ActionBlock> Actions { get; } = new List<ActionBlock>();
    }
}
