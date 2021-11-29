using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    internal class RuleBlock : CodeBlock
    {
        public RuleBlock( RuleEventType eventType )
        {

        }

        public List<ConditionBlock> Conditions { get; set; } = new List<ConditionBlock>();

        public List<ActionValue> Actions { get; set; } = new List<ActionValue>();


    }

    internal class ParameterBlock
    {

    }

    internal class CodeBlock : SubroutineBlock
    {

    }

    internal class SubroutineBlock
    {
        public SubroutineBlock()
        {

        }
    }
}
