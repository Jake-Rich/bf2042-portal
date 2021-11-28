using System;

namespace BF2042.Scripting
{
    public class HooksGeneric
    {

    }

    public class Hooks
    {
        private void ProcessHook<T>( Action<T> context ) where T : HookContext
        {
            throw new NotImplementedException();

            //var context = Activator.CreateInstance<T>();
            //
            //BoolValue result = hook( context );
        }

        public void OnPlayerJoinedGame( Action<OnPlayerJoinGame> context ) 
        {
            ProcessHook( context );
        }
        
        public void OnPlayerLeftGame( Action<OnPlayerLeftGame> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerSpawned( Action<OnPlayerDeployed> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerDeath( Action<OnPlayerDied> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerEarnsKill( Action<OnPlayerEarnsKill> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerDowned( Action<OnPlayerDowned> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerRevived( Action<OnPlayerRevived> context )
        {
            ProcessHook( context );
        }

        public void OnTimeLimitReached( Action<OnTimeLimitReached> context )
        {
            ProcessHook( context );
        }

        public void OnGameModeStarted( Action<OnGameModeStarted> context )
        {
            ProcessHook( context );
        }

        public void OnPlayerFullDead( Action<OnPlayerFullDead> context )
        {
            ProcessHook( context );
        }

        public void Example( Func<OnPlayerFullDead, Function> context )
        {

        }
    }
}