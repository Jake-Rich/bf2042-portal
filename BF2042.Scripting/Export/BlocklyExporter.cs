using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BF2042.Scripting
{
    internal class BlocklyExporter
    {
        public List<RuleBlock> Rules { get; } = new List<RuleBlock>();

        public void Import( CodeData data )
        {
            Rules.Clear();

            foreach( var hook in data.Hooks )
            {
                Rules.Add( new RuleBlock( hook.Type )
                {
                    Actions = hook.Actions.ToList(),
                } );
            }
        }

        public string SerializeToString()
        {
            StringBuilder builder = new StringBuilder();

            var settings = new XmlWriterSettings()
            {
                ConformanceLevel = ConformanceLevel.Fragment,
                
            };

            using ( var writer = XmlWriter.Create( builder, settings ) )
            {
                foreach ( var hook in Rules )
                {
                    SerializeRule( hook, writer );
                }
            }

            return builder.ToString();
        }

        private void SerializeRule( RuleBlock rule, XmlWriter writer )
        {
            writer.WriteStartElement( "block" );
            writer.WriteAttributeString( "type", "ruleBlock" );

            foreach( var action in rule.Actions )
            {
                SerializeAction( action, writer );
            }

            writer.WriteEndElement();

            // This is Some random hook stuff?

            //            <block type=\"ruleBlock\">
            //    <mutation isOnGoingEvent=\"false\"></mutation>
            //    <field name=\"NAME\">Vehicle Hooks</field>
            //    <field name=\"EVENTTYPE\">OnPlayerJoinGame</field>
            //    <statement name=\"ACTIONS\">
            //        <block type=\"subroutineInstanceBlock\">
            //            <field name=\"SUBROUTINE_NAME\">CheckVariable</field>
            //        </block>
            //
            //    </statement>
            //
            //</block>
        }

        private void SerializeAction( ActionValue action, XmlWriter writer )
        {
            if ( action is IEnumerable<ActionValue> actions )
            {
                foreach( var subAction in actions )
                {
                    SerializeSingleAction( subAction, writer );
                }
            }
            else if ( action is IfTrue )
            {
                // Special cases for if blocks & such? (yes)
            }
            else
            {
                SerializeSingleAction( action, writer );
            }
        }

        private void SerializeSingleAction( ActionValue action, XmlWriter writer )
        {
            string functionName = action.ActionType.ToString();

            // Convert function name with dictionary here

            writer.WriteStartElement( "block" );

            writer.WriteAttributeString( "type", functionName );

            int index = -1;

            foreach ( var parameter in action.GetParameters() )
            {
                index++;

                if ( parameter == null )
                {
                    continue;
                }

                SerializeParameterStart( index, writer );

                SerializeElementBlock( parameter, writer );

                SerializeParameterEnd( writer );
            }

            writer.WriteEndElement();
        }

        private void SerializeParameterStart( int index, XmlWriter writer )
        {
            writer.WriteStartElement( "value" );
            writer.WriteAttributeString( "name", $"VALUE-{index}" );
        }

        private void SerializeParameterEnd( XmlWriter writer )
        {
            writer.WriteEndElement();
        }

        private void SerializeElementBlock( CommonValue value, XmlWriter writer )
        {
            if ( value == null )
            {
                return;
            }

            // Value = another block
            // Field = hardcoded value

            // block
            //   value 
            //      block
            //         field


            // Instruction -> BlockId
            var blockType = Blocks.GetBlock( value.Instruction );

            writer.WriteStartElement( "block" );

            writer.WriteAttributeString( "type", blockType.BlockId );

            if ( blockType.Fields != null )
            {
                int fieldIndex = -1;

                foreach( var parameter in value.Parameters )
                {
                    fieldIndex++;

                    if ( parameter is UserValue userValue )
                    {
                        var fieldId = blockType.Fields.ElementAtOrDefault( fieldIndex );

                        if ( fieldId == null )
                        {
                            throw new Exception();
                        }

                        writer.WriteStartElement( "field" );
                        writer.WriteAttributeString( "name", fieldId );
                        writer.WriteEndElement();
                    }
                }
            }
            else
            {
                int childIndex = -1;

                if ( value.Parameters == null )
                {
                    Console.WriteLine( $"Warning: No parameters for {value.Instruction}" );
                }
                else
                {
                    foreach ( var parameter in value.Parameters )
                    {
                        childIndex++;

                        SerializeParameterStart( childIndex, writer );

                        SerializeElementBlock( parameter, writer );

                        SerializeParameterEnd( writer );
                    }
                }
            }

            writer.WriteEndElement();
        }

        private void SerializeEnumBlock(XmlWriter writer, EnumValue value )
        {
            writer.WriteStartElement( "block" );



            //writer.WriteAttributeString( "type" );
        }

        private void SerializeBlock( XmlWriter writer, string blockId, string type )
        {

        }
    }

    internal class SimpleBlock
    {
        public string BlockId { get; set; }


    }

    internal class CodeData
    {
        //public List<ActionValue> Actions { get; } = new List<ActionValue>();

        public List<HookFunction> Hooks { get; } = new List<HookFunction>();
    }

    internal class CodeRecorder
    {
        private CodeData _data = new CodeData();

        public void RecordHook( RuleEventType type, Function callback )
        {
            _data.Hooks.Add( new HookFunction( type, callback ) );
        }

        public CodeData GetData()
        {
            return _data;
        }
    }

    internal class HookFunction
    {
        public RuleEventType Type { get; }
        public IReadOnlyCollection<ActionValue> Actions { get; private set; }

        internal HookFunction( RuleEventType type, IEnumerable<ActionValue> actions )
        {
            Type = type;
            Actions = actions.ToArray();
        }
    }
}
