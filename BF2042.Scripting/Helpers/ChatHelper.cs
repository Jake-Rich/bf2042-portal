using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF2042.Scripting
{
    public partial class HookContext
    {
        public ArrayValue<PlayerValue> AllPlayers { get { return new ArrayValue<PlayerValue>( PortalInstruction.GetAllPlayers ); } }


        public ActionValue GlobalChatMessage( StringValue text, NumberValue duration = null )
        {
            return new ActionValue( ActionBlockType.DisplayCustomMessage, text, duration );
        } 
    }
}
