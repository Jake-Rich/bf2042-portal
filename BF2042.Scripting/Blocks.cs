using System.Collections.Generic;
using System.Linq;

namespace BF2042.Scripting
{
    internal static class Blocks
    {
        private static List<Block> AllBlocks = new List<Block>()
        {
            new Block( PortalInstruction.GetPlayerState, "GetSoliderState" ),
            new Block( PortalInstruction.EventPlayer, "EventPlayer" ),
            new Block( PortalInstruction.EventPlayer, "EventOtherPlayer" ),

            new Block( PortalInstruction.Literal_Bool, "Boolean" ).UseFields( "BOOL" ),
            new Block( PortalInstruction.Literal_Number, "Number" ).UseFields( "NUM" ),
            new Block( PortalInstruction.Literal_String, "Text" ).UseFields( "TEXT" ),

            new Block( PortalInstruction.VariableReferenceBlock, "variableReferenceBlock" ).UseFields( "OBJECTIVETYPE", "VAR", "OBJECT"),

        };

        public static Block GetBlock( PortalInstruction instruction )
        {
            var block = AllBlocks.FirstOrDefault( x => x.Instruction == instruction );

            if ( block == null )
            {
                block = new Block( instruction, instruction.ToString() );
            }

            return block;
        }
    }

    internal class Block
    {
        public PortalInstruction Instruction { get; }
        public string BlockId { get; }
        public string[] Fields { get; private set; }

        public Block( PortalInstruction instruction, string blockId )
        {
            Instruction = instruction;
            BlockId = blockId;
        }

        public Block UseFields( params string[] names )
        {
            Fields = names;

            return this;
        }
    }
}
