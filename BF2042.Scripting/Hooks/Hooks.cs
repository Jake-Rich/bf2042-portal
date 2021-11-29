using System;
using System.Reflection;

namespace BF2042.Scripting
{
    public class HooksGeneric
    {

    }

    public class Hooks
    {
        private CodeRecorder _recorder;

        internal Hooks( CodeRecorder recorder )
        {
            _recorder = recorder;
        }

        private void ProcessHook<T>( RuleEventType type, Func<T, Function> func ) where T : HookContext
        {
            T context = Activator.CreateInstance( type: typeof(T), bindingAttr: BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, null, null ) as T;

            var actions = func.Invoke( context );

            _recorder.RecordHook( type, actions );
        }

        public void OnPlayerJoinedGame( Func<OnPlayerJoinGame, Function> context ) 
        {
            ProcessHook( RuleEventType.OnPlayerJoinGame, context );
        }
        
        public void OnPlayerLeftGame( Func<OnPlayerLeftGame, Function> context )
        {
            ProcessHook( RuleEventType.OnPlayerLeaveGame, context );
        }

        public void OnPlayerSpawned( Func<OnPlayerDeployed, Function> context )
        {
            ProcessHook( RuleEventType.OnPlayerDeployed, context );
        }

        public void OnPlayerDeath( Func<OnPlayerDied, Function> context )
        {
            ProcessHook( RuleEventType.OnPlayerDied, context );
        }

        public void OnPlayerEarnsKill( Func<OnPlayerEarnsKill, Function> context )
        {
            ProcessHook( RuleEventType.OnPlayerEarnedKill, context );
        }

        public void OnPlayerDowned( Func<OnPlayerDowned, Function> context )
        {
            ProcessHook( RuleEventType.OnMandown, context );
        }

        public void OnPlayerRevived( Func<OnPlayerRevived, Function> context )
        {
            ProcessHook( RuleEventType.OnRevived, context );
        }

        public void OnTimeLimitReached( Func<OnTimeLimitReached, Function> context )
        {
            ProcessHook( RuleEventType.OnTimeLimitReached, context );
        }

        public void OnGameModeStarted( Func<OnGameModeStarted, Function> context )
        {
            ProcessHook( RuleEventType.OnGameModeStarted, context );
        }

        public void OnGameModeEnded( Func<OnGameModeEnded, Function> context )
        {
            ProcessHook( RuleEventType.OnGameModeEnding, context );
        }

        public void OnPlayerFullDead( Func<OnPlayerFullDead, Function> context )
        {
            ProcessHook( RuleEventType.OnPlayerIrreversiblyDead, context );
        }
    }
}