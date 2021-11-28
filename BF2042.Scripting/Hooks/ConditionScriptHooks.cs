using System;

namespace BF2042.Scripting
{
    public class HookContext<T>
    {
        public void AddCallback( Action<T> callback )
        {

        }
    }

    public class ConditionHookContext<T> : HookContext<T>
    {
        public void AddCondition( Func<T, BoolValue> condition )
        {

        }
    }

    public class ScriptHooks
    {
        private void ProcessHook<T>( Action<ConditionHookContext<T>> context )
        {
            throw new NotImplementedException();

            //var context = Activator.CreateInstance<T>();
            //
            //BoolValue result = hook( context );
        }

        public void OnPlayerJoinedGame( Action<ConditionHookContext<OnPlayerJoinGame>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerLeftGame( Action<ConditionHookContext<OnPlayerLeftGame>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerSpawned( Action<ConditionHookContext<OnPlayerDeployed>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerDeath( Action<ConditionHookContext<OnPlayerDied>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerEarnsKill( Action<ConditionHookContext<OnPlayerEarnsKill>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerDowned( Action<ConditionHookContext<OnPlayerDowned>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerRevived( Action<ConditionHookContext<OnPlayerRevived>> context )
        {
            ProcessHook( context );
        }

        public void OnTimeLimitReached( Action<ConditionHookContext<OnTimeLimitReached>> context )
        {
            ProcessHook( context );
        }

        public void OnGameModeStarted( Action<ConditionHookContext<OnGameModeStarted>> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerFullDead( Action<ConditionHookContext<OnPlayerFullDead>> context )
        {
            ProcessHook( context );
        }
    }
}