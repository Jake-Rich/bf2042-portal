namespace BF2042.Scripting
{

    public abstract class PortalScript<T> : PortalScript where T : VariableContext
    {
        public T Variables { get; }
    }

    public abstract class PortalScript
    {
        public abstract void Setup();

        public ScriptContext ScriptContext { get; }

        private BlocklyExporter _exporter;
        private CodeRecorder _recorder;

        public ScriptHooks Hooks { get; } = new ScriptHooks();

        public ConditionScriptHooks Conditions { get; } = new ConditionScriptHooks();
    }
}