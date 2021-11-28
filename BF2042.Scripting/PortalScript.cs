namespace BF2042.Scripting
{
    public abstract class PortalScript<T> where T : VariableContext
    {
        protected virtual bool StrictMode { get { return true; } }

        public T Variables { get; }

        public Hooks Hooks { get; } = new Hooks();

        public abstract void Setup( ScriptOptions options );

        public ScriptContext ScriptContext { get; }
    }

    public abstract class PortalScript : PortalScript<VariableContext>
    {
        
    }
}