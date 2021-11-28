namespace BF2042.Scripting
{
    public class ScriptContext
    {
        public ArrayValue GetAllPlayers()
        {
            return new ArrayValue( PortalInstruction.GetAllPlayers );
        }
    }

    public class VariableContext
    {
        
    }

    public class MyVariables : VariableContext
    {
        public UniversalValue OkThen { get; }
    }
}