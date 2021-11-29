namespace BF2042.Scripting
{
    public abstract class PortalScript<T> where T : VariableContext
    {
        protected virtual bool StrictMode { get { return true; } }

        public T Variables { get; }

        public Hooks Hooks { get; }

        private CodeRecorder _recorder;
        private BlocklyExporter _exporter;

        public PortalScript()
        {
            _recorder = new CodeRecorder();
            _exporter = new BlocklyExporter();

            Hooks = new Hooks( _recorder );

            Setup( new ScriptOptions() );
        }

        public abstract void Setup( ScriptOptions options );

        public ScriptContext ScriptContext { get; }

        public string ToXML()
        {
            _exporter.Import( _recorder.GetData() );

            return _exporter.SerializeToString();
        }
    }

    public abstract class PortalScript : PortalScript<VariableContext>
    {
        
    }
}